use crate::models::rover::Rover;

impl Rover {
    pub fn execute(&self, commands: &str) -> String {
        String::from("0:0:N")
    }
}

impl Default for Rover {
    fn default() -> Self {
        Self {}
    }
}

#[cfg(test)]
mod rover_controller_should {
    use rstest::rstest;
    use crate::models::rover::Rover;

    #[rstest]
    #[case("", "0:0:N")]
    #[case("L", "0:0:E")]
    fn execute_commands(#[case] commands: &str, #[case] expected_position: String) {
        let rover = Rover::default();

        let position = rover.execute(commands);

        assert_eq!(expected_position, position)
    }
}
