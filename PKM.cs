public struct PKM
{
    public Species dexNum;
    public uint pv;
    public ushort otid;
    public ushort otsid;
    public uint exp;
    public byte friendship;
    public Ability ability;
    public byte marks;
    public Region ogRegion;
    public GameVersion ogGame;
    public byte hpEV, attackEV, defenseEV, speedEV, spAttackEV, spDefenseEV;
    public byte coolCV, beautyCV, cuteCV, smartCV, toughCV, sheenCV;
    public ushort ribbonsSinnoh1, ribbonsSinnoh2, ribbonsSinnoh3, ribbonsSinnoh4, ribbonsHoeen1, ribbonsHoeen2;
    public Move move1, move2, move3, move4;
    public byte move1pp, move2pp, move3pp, move4pp;
    public uint PPUP;
    public byte hpIV, attackIV, defenseIV, speedIV, spAttackIV, spDefenseIV;
    public bool isEgg, isNicknamed;
    public bool fateful;
    public Gender gender;
    public byte altForms;
    public byte sLeaves;
    public ushort eggLocationPt, metLocationPt, eggLocation, metLocation;
    public string nickname, otName;
    public byte[] eggDate, metDate;
    public byte pokerus;
    public Ball pokeball;
    public byte metLevel;
    public Gender otGender;
    public byte encounterType;
    public ushort HeldItem;
    public Nature nature;
}
