Public Class Stats
    Public Property FlatSpellBlockMod As Double
    Public Property PercentMPRegenMod As Double
    Public Property rFlatSpellBlockModPerLevel As Double
    Public Property rFlatArmorModPerLevel As Double
    Public Property PercentPhysicalDamageMod As Double
    Public Property FlatCritChanceMod As Double
    Public Property PercentSpellBlockMod As Double
    Public Property rFlatTimeDeadModPerLevel As Double
    Public Property rFlatMagicDamageModPerLevel As Double
    Public Property rFlatHPModPerLevel As Double
    Public Property rPercentMovementSpeedModPerLevel As Double
    Public Property FlatEXPBonus As Double
    Public Property FlatMPRegenMod As Double
    Public Property rFlatHPRegenModPerLevel As Double
    Public Property FlatBlockMod As Double
    Public Property PercentEXPBonus As Double
    Public Property FlatEnergyPoolMod As Double
    Public Property rFlatEnergyRegenModPerLevel As Double
    Public Property rFlatGoldPer10Mod As Double
    Public Property FlatAttackSpeedMod As Double
    Public Property FlatHPPoolMod As Double
    Public Property PercentAttackSpeedMod As Double
    Public Property rFlatDodgeMod As Double
    Public Property rFlatMPRegenModPerLevel As Double
    Public Property rPercentTimeDeadMod As Double
    Public Property FlatEnergyRegenMod As Double
    Public Property PercentSpellVampMod As Double
    Public Property FlatCritDamageMod As Double
    Public Property rFlatMovementSpeedModPerLevel As Double
    Public Property PercentHPRegenMod As Double
    Public Property rPercentArmorPenetrationModPerLevel As Double
    Public Property PercentArmorMod As Double
    Public Property rFlatMPModPerLevel As Double
    Public Property rFlatArmorPenetrationMod As Double
    Public Property PercentBlockMod As Double
    Public Property PercentMagicDamageMod As Double
    Public Property FlatMPPoolMod As Double
    Public Property FlatPhysicalDamageMod As Double
    Public Property rFlatPhysicalDamageModPerLevel As Double
    Public Property rFlatTimeDeadMod As Double
    Public Property FlatHPRegenMod As Double
    Public Property rFlatCritDamageModPerLevel As Double
    Public Property rFlatCritChanceModPerLevel As Double
    Public Property rFlatDodgeModPerLevel As Double
    Public Property rPercentMagicPenetrationModPerLevel As Double
    Public Property PercentLifeStealMod As Double
    Public Property PercentMovementSpeedMod As Double
    Public Property FlatArmorMod As Double
    Public Property rFlatEnergyModPerLevel As Double
    Public Property rPercentMagicPenetrationMod As Double
    Public Property rPercentTimeDeadModPerLevel As Double
    Public Property PercentMPPoolMod As Double
    Public Property PercentDodgeMod As Double
    Public Property PercentCritChanceMod As Double
    Public Property PercentCritDamageMod As Double
    Public Property rPercentAttackSpeedModPerLevel As Double
    Public Property rFlatMagicPenetrationMod As Double
    Public Property PercentHPPoolMod As Double
    Public Property rPercentArmorPenetrationMod As Double
    Public Property rFlatMagicPenetrationModPerLevel As Double
    Public Property rFlatArmorPenetrationModPerLevel As Double
    Public Property rPercentCooldownModPerLevel As Double
    Public Property FlatMagicDamageMod As Double
    Public Property FlatMovementSpeedMod As Double
    Public Property rPercentCooldownMod As Double
End Class

Public Class Gold
    Public Property total As Integer
    Public Property purchasable As Boolean
    Public Property sell As Integer
    Public Property base As Integer
End Class

Public Class Rune2
    Public Property isRune As Boolean
    Public Property tier As String
    Public Property type As String
End Class

Public Class Basic

End Class

Public Class rune
    Public Property tags As String()

    Public Property sanitizedDescription As String

    Public Property description As String
    Public Property name As String
    Public Property image As Image

    Public Property runeid As Integer
    Public Property inStore As Boolean
    Public Property id As Integer
    Public Property specialRecipe As Integer
    Public Property consumed As Boolean

    Public Property stats As Stats
    Public Property hideFromAll As Boolean
    Public Property consumeOnFull As Boolean
    Public Property stacks As Integer
    Public Property gold As Gold
    Public Property rune As Rune2
    Public Property depth As Integer
End Class