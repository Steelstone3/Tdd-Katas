pub struct Rover {
    pub x: i32,
    pub y: i32,
    pub cardinal: char,
}

impl Default for Rover {
    fn default() -> Self {
        Self {
            cardinal: 'N',
            x: 0,
            y: 0,
        }
    }
}
