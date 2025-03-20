use crate::models::rover::Rover;

impl Rover {
    pub fn execute(&mut self, commands: &str) -> String {
        for command in commands.chars() {
            match command {
                'M' => match self.cardinal {
                    'N' => self.y += 1,
                    'E' => self.x += 1,
                    'S' => self.y -= 1,
                    'W' => self.x -= 1,
                    _ => {},
                },
                'R' => {
                    self.cardinal = match self.cardinal {
                        'N' => 'E',
                        'E' => 'S',
                        'S' => 'W',
                        'W' => 'N',
                        _ => self.cardinal,
                    };
                }
                'L' => {
                    self.cardinal = match self.cardinal {
                        'N' => 'W',
                        'W' => 'S',
                        'S' => 'E',
                        'E' => 'N',
                        _ => self.cardinal,
                    };
                }
                _ => {},
            }
        }

        format!("X {}:Y {}:{}", self.x, self.y, self.cardinal)
    }
}

#[cfg(test)]
mod rover_controller_should {
    use crate::models::rover::Rover;
    use rstest::rstest;

    #[test]
    #[should_panic]
    fn failed_to_execute_command() {
        // given
        let commands = "MRLX";
        let mut rover = Rover::default();

        // when
        rover.execute(commands);
    }

    #[rstest]
    #[case("", "X 0:Y 0:N")]
    #[case("R", "X 0:Y 0:E")]
    #[case("RR", "X 0:Y 0:S")]
    #[case("RRR", "X 0:Y 0:W")]
    #[case("L", "X 0:Y 0:W")]
    #[case("LL", "X 0:Y 0:S")]
    #[case("LLL", "X 0:Y 0:E")]
    #[case("M", "X 0:Y 1:N")]
    #[case("LM", "X -1:Y 0:W")]
    #[case("RM", "X 1:Y 0:E")]
    #[case("RRM", "X 0:Y -1:S")]
    #[case("MMRMMLM", "X 2:Y 3:N")]
    fn execute_commands(#[case] commands: &str, #[case] expected_position: String) {
        // given
        let mut rover = Rover::default();

        // when
        let position = rover.execute(commands);

        // then
        assert_eq!(expected_position, position)
    }
}
