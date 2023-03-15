using System;

//Edited by: Stephen Britt
//     Date: 2/5/2022

class Character {

    // Constants 
    private const sbyte MIN_ABILITY_RANGE = 10;
    private const sbyte MAX_ABILITY_RANGE = 15;

    // private member variables
    private sbyte m_level = 1;
    private long m_experiencePoints = 0;
    private sbyte m_strength;
    private sbyte m_dexterity;
    private sbyte m_constitution;
    private sbyte m_intelligence;
    private sbyte m_wisdom;
    private sbyte m_charisma;
    private short m_totalHitPoints;
    private short m_currentHitPoints;
    private string m_name;
    private string m_class;
    private string m_race;

    // constructors
    public Character() {
        this.Name = "No Name";
        this.AClass = "No Class";
        this.Race = "No Race";

        GenerateAbilityScores();

        m_totalHitPoints = (short)((m_constitution * 10) + m_strength);
        m_currentHitPoints = m_totalHitPoints;
    } // end constructor 

    public Character(string name, string aClass, string race) {
        this.Name = name;
        this.AClass = aClass;
        this.Race = race;

        GenerateAbilityScores();

        m_totalHitPoints = (short)((m_constitution * 10) + m_strength);
        m_currentHitPoints = m_totalHitPoints;
    } // end constructor

    // properties
    public string Name {
        get {
            return m_name;
        } // end get
        set {
            if (value == string.Empty) {
                throw new Exception("Character names must have one or more characters.");
            }
            else {
                m_name = value;
            } // end if
        } // end set
    } // end property

    public string AClass {
        get {
            return m_class;
        } // end get
        set {
            if (value == string.Empty) {
                throw new Exception("Character classes must have one or more characters.");
            }
            else {
                m_class = value;
            } // end if
        } // end set
    } // end property

    public string Race {
        get {
            return m_race;
        } // end get
        set {
            if (value == string.Empty) {
                throw new Exception("Character races must have one or more characters.");
            }
            else {
                m_race = value;
            } // end if
        } // end set
    } // end property 

    // methods
    private void GenerateAbilityScores() {
        Random rnd = new Random();

        m_strength = (sbyte)rnd.Next(MIN_ABILITY_RANGE, MAX_ABILITY_RANGE + 1);
        m_dexterity = (sbyte)rnd.Next(MIN_ABILITY_RANGE, MAX_ABILITY_RANGE + 1);
        m_constitution = (sbyte)rnd.Next(MIN_ABILITY_RANGE, MAX_ABILITY_RANGE + 1);
        m_intelligence = (sbyte)rnd.Next(MIN_ABILITY_RANGE, MAX_ABILITY_RANGE + 1);
        m_wisdom = (sbyte)rnd.Next(MIN_ABILITY_RANGE, MAX_ABILITY_RANGE + 1);
        m_charisma = (sbyte)rnd.Next(MIN_ABILITY_RANGE, MAX_ABILITY_RANGE + 1);
    } // end method 

    public void IncrementStrength() {
        m_strength++;   // Adds 1 to m_strength 
    } // end method 

    public void IncrementDexterity() {
        m_dexterity++;
    } // end method

    public void IncrementConstitution() {
        m_constitution++;
    } // end method

    public void IncrementIntelligence() {
        m_intelligence++;
    } // end method

    public void IncrementWisdom() {
        m_wisdom++;
    } // end method

    public void IncrementCharisma() {
        m_charisma++;
    } // end method

    public void Rest() {
        m_currentHitPoints = m_totalHitPoints;
    } // end method

    public void LevelUp() {
        m_level++;
        m_strength++;
        m_dexterity++;
        m_constitution++;
        m_intelligence++;
        m_wisdom++;
        m_charisma++;
        m_totalHitPoints += m_constitution;
    } // end method

    public void DamageHitPoints(short points) {
        if ((m_currentHitPoints - points) < 0) {
            m_currentHitPoints = 0;
        } else {
            m_currentHitPoints -= points;
        } // end if        
    } // end method 

    public void RestoreHitPoints(short points) {
        if ((m_currentHitPoints + points) > m_totalHitPoints) {
            m_currentHitPoints = m_totalHitPoints;
        } else {
            m_currentHitPoints += points;
        } // end if        
    } // end method

    public void IncreaseXP(short points) {
        m_experiencePoints += points;
    } // end method

    public string GetHealthInfo() {
        return $"{m_currentHitPoints}/{m_totalHitPoints}";
    } // end method

    public sbyte GetAttackValue() {
        Random rnd = new Random();

        int minValue = m_strength * 3;
        int maxValue = m_strength * 3 + m_dexterity + 1;

        return (sbyte)rnd.Next(minValue, maxValue);
    } // end method 

    public sbyte GetArmorValue() {
        return (sbyte)((m_strength + m_dexterity + m_intelligence) / 4);
    } // end method

    public sbyte GetLevel() {
        return m_level;
    } // end method 

    public long GetExperiencePoints() {
        return m_experiencePoints;
    } // end method
} // end class