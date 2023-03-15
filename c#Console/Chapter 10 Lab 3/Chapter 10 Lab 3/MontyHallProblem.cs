using System;
using System.Linq;
using System.Collections.Generic;

class MontyHallProblem {
    // class random object
    private Random rnd = new Random();

    // public enums
    public enum GameStrategy {
        Keep = 0,
        Switch = 1,
        Random = 2
    } // end enum

    public enum DoorPrize {
        Null = 0,
        Goat = 1,
        Car = 2
    } // end enum

    public enum GameResult {
        Won = 0,
        Lost = 1
    } // end enum

    // private member variables
    private List<DoorPrize> m_doors = new List<DoorPrize>();

    // class constructor
    public MontyHallProblem() {
        m_doors.Add(DoorPrize.Null);

        // first door
        if (rnd.Next(1, 3) == 1) {
            m_doors.Add(DoorPrize.Goat);
        } else {
            m_doors.Add(DoorPrize.Car);
        } // end if

        // second door
        if (m_doors.Contains(DoorPrize.Car)) {
            m_doors.Add(DoorPrize.Goat);
        } else {
            if (rnd.Next(1, 3) == 1) {
                m_doors.Add(DoorPrize.Goat);
            } else {
                m_doors.Add(DoorPrize.Car);
            } // end if
        } // end if

        // final door
        if (m_doors.Contains(DoorPrize.Car)) {
            m_doors.Add(DoorPrize.Goat);
        } else {
            m_doors.Add(DoorPrize.Car);
        }
    } // end constructor

    // class properties
    private int CarDoor {
        get {
            return m_doors.IndexOf(DoorPrize.Car);
        } // end get
    } // end property

    private int GetPlayerDoor() {
        // randomly generate an integer to represent the door chosen by the player.
        // this int will be the index of the door in the m_doors list
        return rnd.Next(1, m_doors.Count);
    } // end method

    private int GetHostDoor(int playerChoice) {
        // return a random int for the index of a door that is not the one chosen by the player,
        // of the one with the car
        int hostDoor = rnd.Next(1, m_doors.Count);
        while (hostDoor == playerChoice || hostDoor == this.CarDoor) {
            hostDoor = rnd.Next(1, m_doors.Count);
        } // end while
            
        return hostDoor;
    } // end method

    public GameResult PlayGame(GameStrategy strategy) {
        // first, the player chooses a random door
        int playerChoice = this.GetPlayerDoor();

        // the host opens a door that is not the player choice or the car door
        int hostDoor = GetHostDoor(playerChoice);

        // the host asks the player whether they will KEEP their door
        // SWITCH to the remaining door or RANDOMly pick a strategy
        // then output the result
        int newDoor;
        GameResult endResult = GameResult.Won;
        if (strategy == GameStrategy.Keep) { // KEEP strategy
            if (playerChoice == this.CarDoor) {
                endResult = GameResult.Won;
            } else {
                endResult = GameResult.Lost;
            } // end if
        } else if (strategy == GameStrategy.Switch) { // SWITCH strategy
            newDoor = rnd.Next(1, m_doors.Count);
            while (newDoor == playerChoice || newDoor == hostDoor) {
                newDoor = rnd.Next(1, m_doors.Count);
            } // end while

            if (newDoor == this.CarDoor) {
                endResult = GameResult.Won;
            } else {
                endResult = GameResult.Lost;
            } // end if
        } else if (strategy == GameStrategy.Random) { // RANDOM strategy
            GameStrategy randomStrategy = (GameStrategy)rnd.Next(0, 2);
            if (randomStrategy == GameStrategy.Keep) {
                if (playerChoice == this.CarDoor) {
                    endResult = GameResult.Won;
                } else {
                    endResult = GameResult.Lost;
                } // end if
            } else {
                newDoor = rnd.Next(1, m_doors.Count);
                while (newDoor == playerChoice || newDoor == hostDoor) {
                    newDoor = rnd.Next(1, m_doors.Count);
                } // end while

                if (newDoor == this.CarDoor) {
                    endResult = GameResult.Won;
                } else {
                    endResult = GameResult.Lost;
                } // end if
            } // end if
        } // end if

        return endResult;
    } // end method
} // end class