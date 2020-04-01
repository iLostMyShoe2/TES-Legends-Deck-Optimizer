module Cards

type CardType =
    | Creature
    | Action
    | Item
    | Support

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


type Animal =
    | Wolf
    | Beast
    | Reptile
    | Lizard
    | Fish

type Race =
    | Argonian
    | Breton
    | DarkElf
    | HighElf
    | Imperial
    | Khajiit
    | Nord
    | Orc
    | Goblin
    | Ogre
    | Redguard
    | WoodElf
    | Dragon
    | Mantikora
    | Defense
    | Animal
    | Daedra
    | Grummite
    | Vampire
    | God
    | AshCreature
    | Nereid
    | Spriggan
    | Wraith
    | Skeleton
    | Spirit
    | Atronach
    | Fabricant
    | Wamasu
    | Harpy
    | Chaurus
    | Centaur
    | Minotaur
    | Elytra
    | Falmer
    | Lurcher
    | Spider
    | Troll
    | Portal
    | Mummy
    | Werewolf
    | Mammoth
    | Ayleid
    | Imp
    | Dwemer
    | Factotum
    | Automaton
    | Dreugh
    | Reachman
    | Mudcrab
    | Skeever

type Card = {
    Name: string
    Description: string
    CardType: CardType
    Races: Race list
}

