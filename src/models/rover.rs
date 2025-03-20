pub struct Rover {
    pub cardinal: char,
}

impl Default for Rover {
    fn default() -> Self {
        Self { cardinal: 'N' }
    }
}
