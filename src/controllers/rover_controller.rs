use crate::models::rover::Rover;

impl Rover {
    pub fn execute(&mut self, commands: &str) -> String {
        for command in commands.chars() {
            match command {
                'L' => {
                    self.cardinal = match self.cardinal {
                        'N' => 'W',
                        'W' => 'S',
                        'S' => 'E',
                        'E' => 'N',
                        _ => panic!(),
                    };
                },
                'R' => {
                    self.cardinal = match self.cardinal {
                        'N' => 'E',
                        'E' => 'S',
                        'S' => 'W',
                        'W' => 'N',
                        _ => panic!(),
                    };
                },
                _ => panic!()
            }
        }

        format!("0:0:{}", self.cardinal)
    }
}

#[cfg(test)]
mod rover_controller_should {
    use crate::models::rover::Rover;
    use rstest::rstest;

    #[rstest]
    #[case("", "0:0:N")]
    #[case("R", "0:0:E")]
    #[case("RR", "0:0:S")]
    #[case("RRR", "0:0:W")]
    #[case("L", "0:0:W")]
    #[case("LL", "0:0:S")]
    #[case("LLL", "0:0:E")]
    fn execute_commands(#[case] commands: &str, #[case] expected_position: String) {
        let mut rover = Rover::default();

        let position = rover.execute(commands);

        assert_eq!(expected_position, position)
    }
}
