module Cards

type CardType =
    | Creature
    | Action
    | Item
    | Support

type CardSubType =
    | Skeleton
    | Dragon
    | Minotaur
    | Khajiit

type CardAttributes =
    | Strength
    | Intelligence
    | Willpower
    | Agility
    | Endurance
    | Neutral

type DualCardClasses =
    | Archer
    | Assassin
    | Battlemage
    | Crusader
    | Mage
    | Monk
    | Scout
    | Sorcerer
    | Spellsword
    | Warrior

type TriCardClasses =
    | HouseRedoran
    | HouseTelvanni
    | HouseHlaalu
    | TribunalTemple
    | HouseDagoth
    | EbonheartPact
    | DaggerfallCovenant
    | AldmeriDominion
    | TheGuildsworn
    | TheEmpireOfCyrodiil

type CardRarity =
    | Common
    | Epic
    | Legendary
    | Rare

type CardUnique =
    | Unique
    | NotUnique

type Race =
    | Argonian
    | Breton
    | DarkElf
    | HighElf
    | Imperial
    | Khajiit
    | Nord
    | Orc
    | Redguard
    | WoodElf

type Card = {
    Name: string
    Description: string
    Races: Race list
}

