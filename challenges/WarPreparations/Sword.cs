using System;

public record Sword(Material Material, Gemstone Gemstone, float Length, float CrossguardWidth);

public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstone { None, Emerald, Amber, Sapphire, Diamond, Bitstone }