use models::rover::Rover;

mod controllers;
mod models;

fn main() {
    let mut rover = Rover::default();

    let location = rover.execute("MMRMMLM");

    println!("{}", location);
}
