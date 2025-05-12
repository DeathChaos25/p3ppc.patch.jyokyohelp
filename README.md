# Custom In-Combat Skill Effect Text for P3P (Steam version)  
  
Allows for mods to have a custom effect description when using certain skills in combat (such as stat up skills), also supports removing messages from existing skills.  

Effect messages are taken from the BMD file embedded inside the MSG.TBL file that is found inside the umd0 cpk.  


# How to Use
Add this mod as a dependency to your mod of choice  
Inside your mod, add a folder named "skill"  
Inside this "skill" folder, create a txt file named "datJyokyoHelp.txt"


Then, inside the txt file, format the data the following way:  

skillID | messageID
  
Example:  
226 | 35  

The given example would make the Rebellion skill (skill ID 226) no longer show the "Critical Rate up!" message, and instead will now show "Enemy can't use fusion spells." as the effect message (message id 35).  

![sample](https://i.imgur.com/LpIRelW.jpeg)  

  
Note that you can have multiple lines in the txt file to patch multiple skills at once, just make sure all lines follow the proper formatting.  

# Documentation

For a list of Skill IDs, [please refer to the Amicitia Wiki's page for P3P Skills](https://amicitia.miraheze.org/wiki/Persona_3_Portable/Skills).  

For a list of messages and their message ID, while they can be found by dumping the BMD file embedded in MSG.TBL, they will be listed below for convenience:  
| ID | Name | Message |
|----|------|---------|
| 0 | jyokyohelp_000_1 | Cannot proceed. |
| 1 | jyokyohelp_000_2 | This is a bug 02. |
| 2 | jyokyohelp_AVOID_PLAYER | Missed! |
| 3 | jyokyohelp_AVOID_ENEMY | Attack dodged! |
| 4 | jyokyohelp_ESCAPE_PLAYER | This is a bug 04. |
| 5 | jyokyohelp_ESCAPE_ENEMY | [var0] ran away... |
| 6 | jyokyohelp_BAD_ATTACK_PL | [var0] turned against the party! |
| 7 | jyokyohelp_BAD_ATTACK_EN | [var0] attacked its allies! |
| 8 | jyokyohelp_NOUSATU_PLAYE | [var0] has been charmed! |
| 9 | jyokyohelp_NOUSATU_ENEMY | [var0] has been charmed! |
| 10 | jyokyohelp_HYOKETU_PLAYE | [var0] can't move! |
| 11 | jyokyohelp_HYOKETU_ENEMY | [var0] can't move! |
| 12 | jyokyohelp_SHOCK_PLAYER | [var0] can't move! |
| 13 | jyokyohelp_SHOCK_ENEMY | [var0] can't move! |
| 14 | jyokyohelp_KYOUHU_ESCAPE | [var0] withdrew from battle! |
| 15 | jyokyohelp_KYOUHU_ESCAPE_2 | [var0] ran away! |
| 16 | jyokyohelp_KYOUHU_WAIT_P | [var0] is paralyzed with fear! |
| 17 | jyokyohelp_KYOUHU_WAIT_E | [var0] is paralyzed with fear! |
| 18 | jyokyohelp_YAKEKUSO_ATTA | [var0] is enraged! |
| 19 | jyokyohelp_YAKEKUSO_ATTA_2 | [var0] is enraged! |
| 20 | jyokyohelp_OVERHEAT_WAIT | [var0] has overheated! |
| 21 | jyokyohelp_OVERHEAT_WAIT_2 | [var0] has overheated! |
| 22 | jyokyohelp_BATK_MATK_RES | Attack reverted! |
| 23 | jyokyohelp_BATK_MATK_RES_2 | Attack reverted! |
| 24 | jyokyohelp_HIT_ESC_RESET | Hit/Evasion Rate reverted! |
| 25 | jyokyohelp_HIT_ESC_RESET_2 | Hit/Evasion Rate reverted! |
| 26 | jyokyohelp_DEF_RESET_PLA | Defense reverted! |
| 27 | jyokyohelp_DEF_RESET_ENE | Defense reverted! |
| 28 | jyokyohelp_HIRISK_RESET_ | Critical Rate reverted! |
| 29 | jyokyohelp_HIRISK_RESET__2 | Critical Rate reverted! |
| 30 | jyokyohelp_RISKHG_RESET_ | Critical Rate reverted! |
| 31 | jyokyohelp_RISKHG_RESET__2 | Critical Rate reverted! |
| 32 | jyokyohelp_BADx2_RESET_P | Ailment Susceptibility reverted! |
| 33 | jyokyohelp_BADx2_RESET_E | Ailment Susceptibility reverted! |
| 34 | jyokyohelp_INFINI_RESET_ | Invulnerability wore off! |
| 35 | jyokyohelp_INFINI_RESET__2 | Enemy can't use fusion spells. |
| 36 | jyokyohelp_VALHOL_RESET_ | Invulnerability wore off! |
| 37 | jyokyohelp_VALHOL_RESET__2 | Enemy can't use fusion spells. |
| 38 | jyokyohelp_GADENT_RESET_ | Evasion Rate reverted! |
| 39 | jyokyohelp_GADENT_RESET__2 | Enemy can't use fusion spells.? |
| 40 | jyokyohelp_NOUSATU_RECOV | [var0] has recovered! |
| 41 | jyokyohelp_NOUSATU_RECOV_2 | [var0] has recovered! |
| 42 | jyokyohelp_DOUYOU_RECOVE | [var0] has recovered! |
| 43 | jyokyohelp_DOUYOU_RECOVE_2 | [var0] has recovered! |
| 44 | jyokyohelp_PANIC_RECOVER | [var0] has recovered! |
| 45 | jyokyohelp_PANIC_RECOVER_2 | [var0] has recovered! |
| 46 | jyokyohelp_KYOUHU_RECOVE | [var0] has recovered! |
| 47 | jyokyohelp_KYOUHU_RECOVE_2 | [var0] has recovered! |
| 48 | jyokyohelp_YAKEKUSO_RECO | [var0] has recovered! |
| 49 | jyokyohelp_YAKEKUSO_RECO_2 | [var0] has recovered! |
| 50 | jyokyohelp_HYOKETU_RECOV | [var0] has recovered! |
| 51 | jyokyohelp_HYOKETU_RECOV_2 | [var0] has recovered! |
| 52 | jyokyohelp_SHOCK_RECOVER | [var0] has recovered! |
| 53 | jyokyohelp_SHOCK_RECOVER_2 | [var0] has recovered! |
| 54 | jyokyohelp_OVERLIMIT_REC | Orgia Mode suspended. |
| 55 | jyokyohelp_OVERLIMIT_REC_2 | Orgia Mode suspended. |
| 56 | jyokyohelp_OVERHEAT_RECO | Cooled down! |
| 57 | jyokyohelp_OVERHEAT_RECO_2 | Cooled down! |
| 58 | jyokyohelp_HP_PLAYER | Insufficient HP! |
| 59 | jyokyohelp_HP_ENEMY | Insufficient HP! |
| 60 | jyokyohelp_SP_PLAYER | Insufficient SP! |
| 61 | jyokyohelp_SP_ENEMY | Insufficient SP! |
| 62 | jyokyohelp_PANIC_ERROR_P | Can't concentrate! |
| 63 | jyokyohelp_PANIC_ERROR_E | Can't concentrate! |
| 64 | jyokyohelp_KUISIB_PLAYER | [var0] withstood the attack! |
| 65 | jyokyohelp_KUISIB_ENEMY | [var0] withstood the attack! |
| 66 | jyokyohelp_FUKUTU_PLAYER | [var0] survived! HP restored! |
| 67 | jyokyohelp_FUKUTU_ENEMY | [var0] survived! HP restored! |
| 68 | jyokyohelp_YAMIYO_TAKE_P | Moonless Gown activated! |
| 69 | jyokyohelp_YAMIYO_TAKE_E | Moonless Gown activated! |
| 70 | jyokyohelp_YAMIYO_DISARM | Moonless Gown lifted! |
| 71 | jyokyohelp_YAMIYO2_DISAR | Moonless Gown lifted! |
| 72 | jyokyohelp_BATK_MATK_SET | Attack up! |
| 73 | jyokyohelp_BATK_MATK_SET_2 | Attack up! |
| 74 | jyokyohelp_HIT_ESC_SET_P | Hit/Evasion Rate up! |
| 75 | jyokyohelp_HIT_ESC_SET_E | Hit/Evasion Rate up! |
| 76 | jyokyohelp_DEF_SET_PLAYE | Defense up! |
| 77 | jyokyohelp_DEF_SET_ENEMY | Defense up! |
| 78 | jyokyohelp_HIRISK_SET_PL | Critical Rate up! |
| 79 | jyokyohelp_HIRISK_SET_EN | Critical Rate up! |
| 80 | jyokyohelp_RISKHG_SET_PL | Critical Rate way up! |
| 81 | jyokyohelp_RISKHG_SET_EN | Critical Rate way up! |
| 82 | jyokyohelp_BADx2_SET_PLA | Ailment Susceptibility up! |
| 83 | jyokyohelp_BADx2_SET_ENE | Ailment Susceptibility up! |
| 84 | jyokyohelp_INFINI_SET_PL | Party became invulnerable! |
| 85 | jyokyohelp_INFINI_SET_EN | Enemy doesn't use. |
| 86 | jyokyohelp_VALHOL_SET_PL | [var0] became invulnerable! |
| 87 | jyokyohelp_VALHOL_SET_EN | Not possible |
| 88 | jyokyohelp_GADENT_SET_PL | Evasion Rate up, HP restored! |
| 89 | jyokyohelp_GADENT_SET_EN | Not possible |
| 90 | jyokyohelp_AGINDA_RESET_ | Fire affinity reverted! |
| 91 | jyokyohelp_AGINDA_RESET__2 | Fire affinity reverted! |
| 92 | jyokyohelp_BUFNDA_RESET_ | Ice affinity reverted! |
| 93 | jyokyohelp_BUFNDA_RESET__2 | Ice affinity reverted! |
| 94 | jyokyohelp_GALNDA_RESET_ | Wind affinity reverted! |
| 95 | jyokyohelp_GALNDA_RESET__2 | Wind affinity reverted! |
| 96 | jyokyohelp_JIONDA_RESET_ | Electricity affinity reverted! |
| 97 | jyokyohelp_JIONDA_RESET__2 | Electricity affinity reverted! |
| 98 | jyokyohelp_JAKUTAI_IMPOS | No effect! |
| 99 | jyokyohelp_JAKUTAI_IMPOS_2 | No effect! |
| 100 | jyokyohelp_MANATU_KOUKA1 | All enemies knocked down! |
| 101 | jyokyohelp_MANATU_KOUKA1_2 | Enemy knocked down! |
| 102 | jyokyohelp_MANATU_KOUKA2 | Ally knocked down! |
| 103 | jyokyohelp_MANATU_KOUKA2_2 | Ally knocked down! |
| 104 | jyokyohelp_MANATU_KOUKA3 | Everyone knocked down! |
| 105 | jyokyohelp_MANATU_KOUKA3_2 | Everyone knocked down! |
| 106 | jyokyohelp_MANATU_KOUKA4 | No effect! |
| 107 | jyokyohelp_MANATU_KOUKA4_2 | No effect! |
| 108 | jyokyohelp_MANATU_KOUKA5 | Party's HP/SP fully restored! |
| 109 | jyokyohelp_MANATU_KOUKA5_2 | Party's HP/SP fully restored! |
| 110 | jyokyohelp_MANATU_KOUKA6 | Enemy's HP/SP fully restored! |
| 111 | jyokyohelp_MANATU_KOUKA6_2 | Enemy's HP/SP fully restored! |
| 112 | jyokyohelp_MANATU_KOUKA7 | Everyone's HP/SP fully restored! |
| 113 | jyokyohelp_MANATU_KOUKA7_2 | Everyone's HP/SP fully restored! |
| 114 | jyokyohelp_MANATU_KOUKA8 | Reserve |
| 115 | jyokyohelp_MANATU_KOUKA8_2 | Reserve |
| 116 | jyokyohelp_MANATU_KOUKA9 | Reserve |
| 117 | jyokyohelp_MANATU_KOUKA9_2 | Reserve |
| 118 | jyokyohelp_MANATU_KOUKA1_3 | Everyone now has an ailment! |
| 119 | jyokyohelp_MANATU_KOUKA1_4 | Everyone now has an ailment! |
| 120 | jyokyohelp_MANATU_KOUKA1_5 | Reserve |
| 121 | jyokyohelp_MANATU_KOUKA1_6 | Reserve |
| 122 | jyokyohelp_MANATU_KOUKA1_7 | Reserve |
| 123 | jyokyohelp_MANATU_KOUKA1_8 | Reserve |
| 124 | jyokyohelp_MANATU_KOUKA1_9 | Reserve |
| 125 | jyokyohelp_MANATU_KOUKA1_10 | Reserve |
| 126 | jyokyohelp_MANATU_KOUKA1_11 | Reserve |
| 127 | jyokyohelp_MANATU_KOUKA1_12 | Reserve |
| 128 | jyokyohelp_MANATU_KOUKA1_13 | Reserve |
| 129 | jyokyohelp_MANATU_KOUKA1_14 | Reserve |
| 130 | jyokyohelp_MANATU_KOUKA1_15 | Reserve |
| 131 | jyokyohelp_MANATU_KOUKA1_16 | Reserve |
| 132 | jyokyohelp_TRICKSTAR_KIM | Command ignored! |
| 133 | jyokyohelp_TRICKSTAR_KIM_2 | Command ignored! |
| 134 | jyokyohelp_BOMB_PLAYER | Turned into a bomb! |
| 135 | jyokyohelp_BOMB_ENEMY | Turned into a bomb! |
| 136 | jyokyohelp_OVERLIMIT_STA | Orgia Mode initiated! |
| 137 | jyokyohelp_OVERLIMIT_STA_2 | Orgia Mode initiated! |
| 138 | jyokyohelp_BATK_MATK_DOW | Attack down! |
| 139 | jyokyohelp_BATK_MATK_DOW_2 | Attack down! |
| 140 | jyokyohelp_HIT_ESC_DOWN_ | Hit/Evasion Rate down! |
| 141 | jyokyohelp_HIT_ESC_DOWN__2 | Hit/Evasion Rate down! |
| 142 | jyokyohelp_DEF_DOWN_SET_ | Defense down! |
| 143 | jyokyohelp_DEF_DOWN_SET__2 | Defense down! |
| 144 | jyokyohelp_SINTAKU1_PLAY | HP fully restored! |
| 145 | jyokyohelp_SINTAKU1_ENEM | HP fully restored! |
| 146 | jyokyohelp_SINTAKU2_PLAY | SP fully restored! |
| 147 | jyokyohelp_SINTAKU2_ENEM | SP fully restored! |
| 148 | jyokyohelp_SINTAKU3_PLAY | HP/SP fully restored! |
| 149 | jyokyohelp_SINTAKU3_ENEM | HP/SP fully restored! |
| 150 | jyokyohelp_SINTAKU4_PLAY | All ailments cured! |
| 151 | jyokyohelp_SINTAKU4_ENEM | All ailments cured! |
| 152 | jyokyohelp_SINTAKU5_PLAY | HP reduced to 1! |
| 153 | jyokyohelp_SINTAKU5_ENEM | HP reduced to 1! |
| 154 | jyokyohelp_DEKAJA_PLAYER | Stat increase nullified! |
| 155 | jyokyohelp_DEKAJA_ENEMY | Stat increase nullified! |
| 156 | jyokyohelp_DEKUNDA_PLAYE | Stat decrease nullified! |
| 157 | jyokyohelp_DEKUNDA_ENEMY | Stat decrease nullified! |
| 158 | jyokyohelp_POWERCHARGE_P | [var0] has charged up! |
| 159 | jyokyohelp_POWERCHARGE_E | [var0] has charged up! |
| 160 | jyokyohelp_MINDCHARGE_PL | [var0] is focused now! |
| 161 | jyokyohelp_MINDCHARGE_EN | [var0] is focused now! |
| 162 | jyokyohelp_DOWN_HIROU_PL | [var0] is too tired to get up! |
| 163 | jyokyohelp_DOWN_HIROU_EN | [var0] is too tired to get up! |
| 164 | jyokyohelp_PARADIGM_SHIF | 's properties changed! |
| 165 | jyokyohelp_PARADIG_SHIFT | 's properties changed! |
| 166 | jyokyohelp_K_AGINDA2_PLA | Fire resistance nullified! |
| 167 | jyokyohelp_K_AGINDA2_ENE | Fire resistance nullified! |
| 168 | jyokyohelp_K_BUFUNDA2_PL | Ice resistance nullified! |
| 169 | jyokyohelp_K_BUFUNDA2_EN | Ice resistance nullified! |
| 170 | jyokyohelp_K_JIONDA2_PLA | Electricity resistance nullified! |
| 171 | jyokyohelp_K_JIONDA2_ENE | Electricity resistance nullified! |
| 172 | jyokyohelp_K_GARUNDA2_PL | Wind resistance nullified! |
| 173 | jyokyohelp_K_GARUNDA2_EN | Wind resistance nullified! |
| 174 | jyokyohelp_RAKUTAP_PLAYE | Stat increase nullified! |
| 175 | jyokyohelp_RAKUTAP_ENEMY | Stat increase nullified! |
| 176 | jyokyohelp_ROULETTE_KOUK | Enemy's Attack up! |
| 177 | jyokyohelp_ROULETTE_KOUK_2 | Party's Attack up! |
| 178 | jyokyohelp_ROULETTE_KOUK_3 | Enemy's Attack down! |
| 179 | jyokyohelp_ROULETTE_KOUK_4 | Party's Attack down! |
| 180 | jyokyohelp_ROULETTE_KOUK_5 | Enemy's Defense up! |
| 181 | jyokyohelp_ROULETTE_KOUK_6 | Party's Defense up! |
| 182 | jyokyohelp_ROULETTE_KOUK_7 | Enemy's Defense down! |
| 183 | jyokyohelp_ROULETTE_KOUK_8 | Party's Defense down! |
| 184 | jyokyohelp_ROULETTE_KOUK_9 | Enemy is in a panic! |
| 185 | jyokyohelp_ROULETTE_KOUK_10 | Party is in a panic! |
| 186 | jyokyohelp_ROULETTE_KOUK_11 | Enemy is enraged! |
| 187 | jyokyohelp_ROULETTE_KOUK_12 | Party is enraged! |
| 188 | jyokyohelp_ROULETTE_KOUK_13 | Enemy is distressed! |
| 189 | jyokyohelp_ROULETTE_KOUK_14 | Party is distressed! |
| 190 | jyokyohelp_ROULETTE_KOUK_15 | Enemy is fear-stricken! |
| 191 | jyokyohelp_ROULETTE_KOUK_16 | Party is fear-stricken! |
| 192 | jyokyohelp_ROULETTE_KOUK_17 | Light damage to the enemy! |
| 193 | jyokyohelp_ROULETTE_KOUK_18 | Light damage to the party! |
| 194 | jyokyohelp_ROULETTE_KOUK_19 | Moderate damage to the enemy! |
| 195 | jyokyohelp_ROULETTE_KOUK_20 | Moderate damage to the party! |
| 196 | jyokyohelp_ROULETTE_KOUK_21 | Heavy damage to the enemy! |
| 197 | jyokyohelp_ROULETTE_KOUK_22 | Heavy damage to the party! |
| 198 | jyokyohelp_ROULETTE_KOUK_23 | HP restored! |
| 199 | jyokyohelp_ROULETTE_KOUK_24 | HP restored! |
| 200 | jyokyohelp_TARGETNON | No target available. |
| 201 | jyokyohelp_ALREADY | Already in effect. |
| 202 | jyokyohelp_EXCESS | Limit reached. |
| 203 | jyokyohelp_UNNECESSARY | Not necessary. |
| 204 | jyokyohelp_DONTUSE | Can't be used right now! |
| 205 | jyokyohelp_MIXRAID_OFF | [var0] can't use it! |
| 206 | jyokyohelp_HYOKETU_IMPOS | Frozen! Can't move. |
| 207 | jyokyohelp_KANDEN_IMPOSS | Shocked! Can't move. |
| 208 | jyokyohelp_SKILL_NONE | No skills for use in battle! |
| 209 | jyokyohelp_PANIC_IMPOSSI | Too panicked to use a skill! |
| 210 | jyokyohelp_NYX_GOODS_NON | All items gone! |
| 211 | jyokyohelp_GOODS_NONE | No items for use in battle! |
| 212 | jyokyohelp_OPERATION_IMP | No one to give orders to! |
| 213 | jyokyohelp_OPERATION_BRE | Currently not available! |
| 214 | jyokyohelp_PERSONA_NONE | You don't have any other Personas! |
| 215 | jyokyohelp_PERSONA_ALREA | You've already changed Personas! |
| 216 | jyokyohelp_ESCAPE_IMPOSS | You can't escape! |
| 217 | jyokyohelp_ESCAPE_FAILUR | You failed to escape! |
| 218 | jyokyohelp_NOEFFECT | No effect! |
| 219 | jyokyohelp_TAIKI_MAYA | [var0] seems bewildered. |
| 220 | jyokyohelp_GIGAS_AISYO | 's atmosphere changed. |
| 221 | jyokyohelp_TAIBAN_TAIKI | [var0] isn't doing anything. |
| 222 | jyokyohelp_TAIBAN_TAIKI2 | [var0] is waiting to see what happens. |
| 223 | jyokyohelp_TAIBAN_HELL | [var0] is smiling eerily. |
| 224 | jyokyohelp_TAIKI_NYX | [var0] is smiling arrogantly. |
| 225 | jyokyohelp_TAIKI_HERMIT | [var0] is emitting an odd light. |
| 226 | jyokyohelp_TAIKI_RARE | [var0] is waiting restlessly. |
| 227 | jyokyohelp_TAIKI_METIS | [var0] is hesitating. |
| 228 | jyokyohelp_HOMUNCULUS | The Homunculus sacrificed itself! |
| 229 | jyokyohelp_TAIKI_HANYOU | [var0] is being cautious. |
| 230 | jyokyohelp_ELIZABETH | [var0] is looking your way. |
| 231 | jyokyohelp_erebos | [var0] can't move. |
| 232 | jyokyohelp_kizetu_PLAYER | [var0] is dizzy. |
| 233 | jyokyohelp_kizetu_ENEMY | [var0] is dizzy. |
| 234 | jyokyohelp_DOKU_HATUDOU_ | [var0] is poisoned. |
| 235 | jyokyohelp_DOKU_HATUDOU__2 | [var0] is poisoned. |
| 236 | jyokyohelp_DOUYOU_HATUDO | [var0] is distressed. |
| 237 | jyokyohelp_DOUYOU_HATUDO_2 | [var0] is distressed. |
| 238 | jyokyohelp_NOUSATU_HATUD | [var0] is charmed. |
| 239 | jyokyohelp_NOUSATU_HATUD_2 | [var0] is charmed. |
| 240 | jyokyohelp_KONRAN_HATUDO | [var0] is panicked. |
| 241 | jyokyohelp_KONRAN_HATUDO_2 | [var0] is panicked. |
| 242 | jyokyohelp_KYOUFU_HATUDO | [var0] is afraid. |
| 243 | jyokyohelp_KYOUFU_HATUDO_2 | [var0] is afraid. |
| 244 | jyokyohelp_YAKEKUSO_HATU | [var0] is enraged. |
| 245 | jyokyohelp_YAKEKUSO_HATU_2 | [var0] is enraged. |
| 246 | jyokyohelp_KANDEN_HATUDO | [var0] is shocked. |
| 247 | jyokyohelp_KANDEN_HATUDO_2 | [var0] is shocked. |
| 248 | jyokyohelp_HYOUKETU_HATU | [var0] is frozen. |
| 249 | jyokyohelp_HYOUKETU_HATU_2 | [var0] is frozen. |
| 250 | jyokyohelp_TETORA_HATUDO | Physical attacks will be repelled. |
| 251 | jyokyohelp_TETORA_HATUDO_2 | Physical attacks will be repelled. |
| 252 | jyokyohelp_MAKARA_HATUDO | Magic attacks will be repelled. |
| 253 | jyokyohelp_MAKARA_HATUDO_2 | Magic attacks will be repelled. |
| 254 | jyokyohelp_NYX_CORE_KUIS | [var0] managed to withstand the attack... |
| 255 | jyokyohelp_NYX_CORE_KUIS_2 | You can't take any more... |
| 256 | jyokyohelp_NYX_CORE_ZERO | You can't fall here...! |
| 257 | jyokyohelp_NYX_CORE_BLOC | You can feel power surging from within... |
| 258 | jyokyohelp_SOUKOUGEKI_YU | Here's our chance foran All-Out Attack! |
| 259 | jyokyohelp_SOUKOUGEKI_YU_2 | Attack |
| 260 | jyokyohelp_SOUKOUGEKI_YU_3 | Relent |
| 261 | jyokyohelp_SOUKOUGEKI_AE | Let us commence withan All-Out Attack! |
| 262 | jyokyohelp_SOUKOUGEKI_AE_2 | The enemy is down.Let's move in! |
| 263 | jyokyohelp_SOUKOUGEKI_AE_3 | Attack |
| 264 | jyokyohelp_SOUKOUGEKI_AE_4 | Relent |
| 265 | jyokyohelp_SOUKOUGEKI_MI | The enemy's down!Let's finish this! |
| 266 | jyokyohelp_SOUKOUGEKI_MI_2 | Attack |
| 267 | jyokyohelp_SOUKOUGEKI_MI_3 | Relent |
| 268 | jyokyohelp_SOUKOUGEKI_JU | Here's our chance!Let's get 'em! |
| 269 | jyokyohelp_SOUKOUGEKI_JU_2 | Attack |
| 270 | jyokyohelp_SOUKOUGEKI_JU_3 | Relent |
| 271 | jyokyohelp_SOUKOUGEKI_SA | I've been waiting forthis! |
| 272 | jyokyohelp_SOUKOUGEKI_SA_2 | Attack |
| 273 | jyokyohelp_SOUKOUGEKI_SA_3 | Relent |
| 274 | jyokyohelp_SOUKOUGEKI_AM | Here's our chance!Let's do it! |
| 275 | jyokyohelp_SOUKOUGEKI_AM_2 | Attack |
| 276 | jyokyohelp_SOUKOUGEKI_AM_3 | Relent |
| 277 | jyokyohelp_SOUKOUGEKI_AR | Alright, let's kick someass! |
| 278 | jyokyohelp_SOUKOUGEKI_AR_2 | Attack |
| 279 | jyokyohelp_SOUKOUGEKI_AR_3 | Relent |
| 280 | jyokyohelp_SOUKOUGEKI_KO | Woof, woof! |
| 281 | jyokyohelp_SOUKOUGEKI_KO_2 | Attack |
| 282 | jyokyohelp_SOUKOUGEKI_KO_3 | Relent |
| 283 | jyokyohelp_SOUKOUGEKI_ME | Alright Sister,let's get 'em! |
| 284 | jyokyohelp_SOUKOUGEKI_ME_2 | Attack |
| 285 | jyokyohelp_SOUKOUGEKI_ME_3 | Relent |
| 286 | jyokyohelp_TOUSOU_YUKARI | I'm sorry, I can't takeanymore. Can I pull out? |
| 287 | jyokyohelp_TOUSOU_YUKARI_2 | "Yes." |
| 288 | jyokyohelp_TOUSOU_YUKARI_3 | ??? |
| 289 | jyokyohelp_TOUSOU_AEGIS_ | Heavy damage sustained.May I withdraw? |
| 290 | jyokyohelp_TOUSOU_AEGIS__2 | "Yes." |
| 291 | jyokyohelp_TOUSOU_AEGIS__3 | ??? |
| 292 | jyokyohelp_TOUSOU_MITURU | I'm in no condition tofight. Can you handle this? |
| 293 | jyokyohelp_TOUSOU_MITURU_2 | "Yes." |
| 294 | jyokyohelp_TOUSOU_MITURU_3 | ??? |
| 295 | jyokyohelp_TOUSOU_JUNPEI | Ugh, I'm in bad shape.Can I sit this one out? |
| 296 | jyokyohelp_TOUSOU_JUNPEI_2 | "Yes." |
| 297 | jyokyohelp_TOUSOU_JUNPEI_3 | ??? |
| 298 | jyokyohelp_TOUSOU_SANADA | I can't hold out muchlonger. Can you manage? |
| 299 | jyokyohelp_TOUSOU_SANADA_2 | "Yes." |
| 300 | jyokyohelp_TOUSOU_SANADA_3 | ??? |
| 301 | jyokyohelp_TOUSOU_AMADA_ | I'm hurt pretty bad...Should I retreat? |
| 302 | jyokyohelp_TOUSOU_AMADA__2 | "Yes." |
| 303 | jyokyohelp_TOUSOU_AMADA__3 | ??? |
| 304 | jyokyohelp_TOUSOU_ARAGAK | I'm not much use to you likethis. Should I fall back? |
| 305 | jyokyohelp_TOUSOU_ARAGAK_2 | "Yes." |
| 306 | jyokyohelp_TOUSOU_ARAGAK_3 | ??? |
| 307 | jyokyohelp_TOUSOU_KOROMA | *whine*> Koromaru wants to go... |
| 308 | jyokyohelp_TOUSOU_KOROMA_2 | "Go." |
| 309 | jyokyohelp_TOUSOU_KOROMA_3 | "Stay!" |
| 310 | jyokyohelp_TOUSOU_METIS_ | I may need to retreat... |
| 311 | jyokyohelp_TOUSOU_METIS__2 | "Alright." |
| 312 | jyokyohelp_TOUSOU_METIS__3 | ??? |
| 313 | jyokyohelp_YELL_0 | The power of friendship surges in you! |
| 314 | jyokyohelp_YELL_1 | [var0] is recovering HP! |
| 315 | jyokyohelp_YELL_2 | A new power is yours! |
| 316 | jyokyohelp_LUCK1 | 1 |
| 317 | jyokyohelp_LUCK2 | 2 |
| 318 | jyokyohelp_LUCK3 | 3 |
| 319 | jyokyohelp_LUCK4 | 4 |
| 320 | jyokyohelp_ANKOKU_YOMI | [var0] revived from the darkness. |
| 321 | jyokyohelp_SINSEI_YOMI | [var0] revived from the light. |
| 322 | jyokyohelp_ROSA | Protected by the Rosary! |
| 323 | jyokyohelp_AMIDA | Protected by the Prayer Beads! |
| 324 | jyokyohelp_NAKAMA_KUI | [var0] withstood the attack! |
