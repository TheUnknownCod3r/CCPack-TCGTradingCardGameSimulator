using CrowdControl.Common;
//using System.Diagnostics.Eventing.Reader;
using ConnectorType = CrowdControl.Common.ConnectorType;

namespace CrowdControl.Games.Packs.TCGCardShopSimulator
{
    public class TCGCardShopSimulator : SimpleTCPPack
    {
        public override string Host => "127.0.0.1";

        public override ushort Port => 51337;

        public override ISimpleTCPPack.MessageFormat MessageFormat => ISimpleTCPPack.MessageFormat.CrowdControlLegacy;

        public TCGCardShopSimulator(UserRecord player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler) { }

        public override Game Game { get; } = new("TCG Card Shop Simulator", "TCGCardShopSimulator", "PC", ConnectorType.SimpleTCPServerConnector);

        public override EffectList Effects => new List<Effect>
        {
                new("Toggle Lights", "lights") { Description = "Toggle the Shop Lights", Category = "Misc" },
                new("Spawn Customer", "spawn") { Description = "Spawns a New Customer", Category = "Spawn" },
                new("Spawn Stinky Customer", "spawnsmelly") { Description = "Spawns a New Extra Stinky Customer", Category = "Spawn" },
                new("Open Store", "open_store") { Description = "Opens the Players Store", Category = "Misc" },
                new("Close Store", "close_store") { Description = "Closes the Players Store", Category = "Misc" },
                new("Unlock Storage", "unlockwh") { Description = "Unlock The Storage room", Category = "Misc" },
                new("Upgrade Storage", "upgradewh") { Description = "Upgrade the Storage Room", Category = "Misc" },
                new("Make All Customers Smelly", "allsmelly") { Description = "Make All the Customers Smelly", Category = "Misc" },
                new("Upgrade the Player Store", "upgradestore") { Description = "Upgrades the Player Store Size", Category = "Misc" },
                new("Make the streamer do the Math", "forcemath") { Description = "Force The Player to do Math", Duration = 30, Category = "Player" },
                new("Teleport Player out of Store", "teleport") { Description = "Teleports the Player over the street", Category = "Player" },
                new("Give $100", "give_100") { Description = "Give the Player $100", Category = "Money" },
                new("Give $1000", "give_1000") { Description = "Give the Player $1000", Category = "Money" },
                new("Give $10000", "give_10000") { Description = "Give The Player $10000", Category = "Money" },
                new("Take $100", "take_100") { Description = "Take away $100 from the Player", Category = "Money" },
                new("Take $1000", "take_1000") { Description = "Take Away $1000 from the Player", Category = "Money" },
                new("Take $10000", "take_10000") { Description = "Take Away $10000 from the Player", Category = "Money" },
                new("Force Cash Only", "forcepayment_cash") { Description = "Force all customers to pay with cash only.", Duration = 60, Category = "Payments" },
                new("Force Card Only", "forcepayment_card") { Description = "Force all customers to pay with card only.", Duration = 60, Category = "Payments" },
                //new("Give 32 Common Packs", "give_common_pack_(32)") { Description = "Send the player a Common Pack (32)", Category = "Items" },
                new("Give 64 Common Packs", "give_common_pack_(64)") { Description = "Send the player a Common Pack (64)", Category = "Items" },
                //new("Give Common Box (4)", "give_common_box_(4)") { Description = "Send the player a Common Box (4)", Category = "Items" },
                new("Give Common Box (8)", "give_common_box_(8)") { Description = "Send the player a Common Box (8)", Category = "Items" },
                //new("Give Rare Pack (32)", "give_rare_pack_(32)") { Description = "Send the player a Rare Pack (32)", Category = "Items" },
                new("Give Rare Pack (64)", "give_rare_pack_(64)") { Description = "Send the player a Rare Pack (64)", Category = "Items" },
                //new("Give Rare Box (4)", "give_rare_box_(4)") { Description = "Send the player a Rare Box (4)", Category = "Items" },
                new("Give Rare Box (8)", "give_rare_box_(8)") { Description = "Send the player a Rare Box (8)", Category = "Items" },
                //new("Give Epic Pack (32)", "give_epic_pack_(32)") { Description = "Send the player an Epic Pack (32)", Category = "Items" },
                new("Give Epic Pack (64)", "give_epic_pack_(64)") { Description = "Send the player an Epic Pack (64)", Category = "Items" },
                //new("Give Epic Box (4)", "give_epic_box_(4)") { Description = "Send the player an Epic Box (4)", Category = "Items" },
                new("Give Epic Box (8)", "give_epic_box_(8)") { Description = "Send the player an Epic Box (8)", Category = "Items" },
                //new("Give Legend Pack (32)", "give_legend_pack_(32)") { Description = "Send the player a Legend Pack (32)", Category = "Items" },
                new("Give Legend Pack (64)", "give_legend_pack_(64)") { Description = "Send the player a Legend Pack (64)", Category = "Items" },
                //new("Give Legend Box (4)", "give_legend_box_(4)") { Description = "Send the player a Legend Box (4)", Category = "Items" },
                new("Give Legend Box (8)", "give_legend_box_(8)") { Description = "Send the player a Legend Box (8)", Category = "Items" },
                //new("Give Deck Box Red (Small Box)", "give_deck_box_red_(sm)") { Description = "Send the player a Red Deck box (Small)", Category = "Items" },
                new("Give Deck Box Red (Large Box)", "give_deck_box_red") { Description = "Send the player a Red Deck Box (Large)", Category = "Items" },
                //new("Give Deck Box Green (Small Box)", "give_deck_box_green_(sm)") { Description = "Send the player a Green Deck Box (Small)", Category = "Items" },
                new("Give Deck Box Green (Large Box)", "give_deck_box_green") { Description = "Send the player a Green Deck Box (Large)", Category = "Items" },
                //new("Give Deck Box Blue (Small Box)", "give_deck_box_blue_(sm)") { Description = "Send the player a Blue Deck Box (Small)", Category = "Items" },
                new("Give Deck Box Blue (Large Box)", "give_deck_box_blue") { Description = "Send the player a Blue Deck Box (Large)", Category = "Items" },
                //new("Give Deck Box Yellow (Small Box)", "give_deck_box_yellow_(sm)") { Description = "Send the player a Yellow Deck Box (Small)", Category = "Items" },
                new("Give Deck Box Yellow (Large Box)", "give_deck_box_yellow") { Description = "Send the player a Yellow Deck Box (Large)", Category = "Items" },
                //new("Give Destiny Common Pack (32)", "give_destiny_common_pack_(32)") { Description = "Send the player a Destiny Common Pack (32) Box", Category = "Items" },
                new("Give Destiny Common Pack (64)", "give_destiny_common_pack_(64)") { Description = "Send the player a Destiny Common Pack (64) Box", Category = "Items" },
                //new("Give Destiny Common Box (4 Packs)", "give_destiny_common_box_(4)") { Description = "Send the player a Destiny Common Box (4)", Category = "Items" },
                new("Give Destiny Common Box (8 Packs)", "give_destiny_common_box_(8)") { Description = "Send the player a Destiny Common Box (8)", Category = "Items" },
                //new("Give Destiny Rare Pack (32)", "give_destiny_rare_pack_(32)") { Description = "Send the player a Destiny Rare Pack (32) Box", Category = "Items" },
                new("Give Destiny Rare Pack (64)", "give_destiny_rare_pack_(64)") { Description = "Send the player a Destiny Rare Pack (64) Box", Category = "Items" },
                //new("Give Destiny Rare Box (4 Packs)", "give_destiny_rare_box_(4)") { Description = "Send the player a Destiny Rare Box (4)", Category = "Items" },
                new("Give Destiny Rare Box (8)", "give_destiny_rare_box_(8)") { Description = "Send the player a Destiny Rare Box (8)", Category = "Items" },
                //new("Give Destiny Epic Pack (32)", "give_destiny_epic_pack_(32)") { Description = "Send the player a Destiny Epic Pack (32) Box", Category = "Items" },
                new("Give Destiny Epic Pack (64)", "give_destiny_epic_pack_(64)") { Description = "Send the player a Destiny Epic Pack (64) Box", Category = "Items" },
                //new("Give Destiny Epic Box (4 Packs)", "give_destiny_epic_box_(4)") { Description = "Send the player a Destiny Epic Box (4) Packs", Category = "Items" },
                new("Give Destiny Epic Box (8 Packs)", "give_destiny_epic_box_(8)") { Description = "Send the player a Destiny Epic Box (8) Packs", Category = "Items" },
                //new("Give Destiny Legend Pack (32)", "give_destiny_legend_pack_(32)") { Description = "Send the player a Destiny Legend Pack (32) Box", Category = "Items" },
                new("Give Destiny Legend Pack (64)", "give_destiny_legend_pack_(64)") { Description = "Send the player a Destiny Legend Pack (64) Box", Category = "Items" },
                //new("Give Destiny Legend Box (4)", "give_destiny_legend_box_(4)") { Description = "Send the player a Destiny Legend Box (4) Packs", Category = "Items" },
                new("Give Destiny Legend Box (8)", "give_destiny_legend_box_(8)") { Description = "Send the player a Destiny Legend Box (8) Packs", Category = "Items" },
                //new("Give Cleanser (16)", "give_cleanser_(16)") { Description = "Send the player a Cleanser pack of 16", Category = "Items" },
                new("Give Cleanser (32)", "give_cleanser_(32)") { Description = "Send the player a Cleanser pack of 32", Category = "Items" },
                new("Give Collection Book", "give_collection_book") { Description = "Send the player a Collection Book", Category = "Items" },
                new("Give D20 Red Dice", "give_d20_dice_red") { Description = "Send the player D20 Red Dice", Category = "Items" },
                new("Give D20 Blue Dice", "give_d20_dice_blue") { Description = "Send the player D20 Blue Dice", Category = "Items" },
                new("Give D20 Black Dice", "give_d20_dice_black") { Description = "Send the player D20 Black Dice", Category = "Items" },
                new("Give D20 White Dice", "give_d20_dice_white") { Description = "Send the player D20 White Dice", Category = "Items" },
                new("Give Piggy Plushie", "give_piggya_plushie") { Description = "Send the player a Piggy Plushie", Category = "Items" },
                new("Give Golem Plushie", "give_golema_plushie") { Description = "Send the player a Golem Plushie", Category = "Items" },
                new("Give Starfish Plushie", "give_starfisha_plushie") { Description = "Send the player a Starfish Plushie", Category = "Items" },
                new("Give Bat Plushie", "give_bata_plushie") { Description = "Send the player a Bat Plushie", Category = "Items" },
                new("Give Toon Plushie", "give_toonz_plushie") { Description = "Send the player a Toon Plushie", Category = "Items" },
                new("Give Kingstar Plushie", "give_kingstar_plushie") { Description = "Send the player a Kingstar Plushie", Category = "Items" },
                new("Give Bonfiox Plushie", "give_bonfiox_plushie") { Description = "Send the player a Bonfiox Plushie", Category = "Items" },
                new("Give Burpig Figurine", "give_burpig_figurine") { Description = "Send the player a Burpig Figurine", Category = "Items" },
                new("Give Inferhog Figurine", "give_inferhog_figurine") { Description = "Send the player a Inferhog Figurine", Category = "Items" },
                new("Give Blazoar Plushie", "give_blazoar_plushie") { Description = "Send the player a Blazoar Plushie", Category = "Items" },
                new("Give Decimite Figurine", "give_decimite_figurine") { Description = "Send the player a Decimite Figurine", Category = "Items" },
                new("Give Meganite Figurine", "give_meganite_figurine") { Description = "Send the player a Meganite Figurine", Category = "Items" },
                new("Give Giganite Statue", "give_giganite_statue") { Description = "Send the player a Giganite Statue", Category = "Items" },
                new("Give Trickstar Figurine", "give_trickstar_figurine") { Description = "Send the player a Trickstar Figurine", Category = "Items" },
                new("Give Princestar Figurine", "give_princestar_figurine") { Description = "Send the player a Princestar Figurine", Category = "Items" },
                new("Give Lunight Figurine", "give_lunight_figurine") { Description = "Send the player a Lunight Figurine", Category = "Items" },
                new("Give Vampicant Figurine", "give_vampicant_figurine") { Description = "Send the player a Vampicant Figurine", Category = "Items" },
                new("Give Dracunix Figurine", "give_dracunix_figurine") { Description = "Send the player a Dracunix Figurine", Category = "Items" },
                new("Give Drilceros Action Figure", "give_drilceros_action_figure") { Description = "Send the player a Drilceros Action Figure", Category = "Items" },
                new("Give Fire Battle Deck", "give_fire_battle_deck") { Description = "Send the player a Fire Battle Deck", Category = "Items" },
                new("Give Earth Battle Deck", "give_earth_battle_deck") { Description = "Send the player a Earth Battle Deck", Category = "Items" },
                new("Give Water Battle Deck", "give_water_battle_deck") { Description = "Send the player a Water Battle Deck", Category = "Items" },
                new("Give Wind Battle Deck", "give_wind_battle_deck") { Description = "Send the player a Wind Battle Deck", Category = "Items" },
                new("Give Fire Destiny Deck", "give_fire_destiny_deck") { Description = "Send the player a Fire Destiny Deck", Category = "Items" },
                new("Give Earth Destiny Deck", "give_earth_destiny_deck") { Description = "Send the player a Earth Destiny Deck", Category = "Items" },
                new("Give Water Destiny Deck", "give_water_destiny_deck") { Description = "Send the player a Water Destiny Deck", Category = "Items" },
                new("Give Wind Destiny Deck", "give_wind_destiny_deck") { Description = "Send the player a Wind Destiny Deck", Category = "Items" },
                new("Give Clear Card Sleeves", "give_card_sleeves_(clear)") { Description = "Send the player Clear Card Sleeves", Category = "Items" },
                new("Give Tetramon Style Card Sleeves", "give_card_sleeves_(tetramon)") { Description = "Send the player Tetramon Card Sleeves", Category = "Items" },
                new("Give Fire Art Card Sleeves", "give_card_sleeves_(fire)") { Description = "Send the player Fire Art Card Sleeves", Category = "Items" },
                new("Give Earth Art Card Sleeves", "give_card_sleeves_(earth)") { Description = "Send the player Earth Art Card Sleeves", Category = "Items" },
                new("Give Water Art Card Sleeves", "give_card_sleeves_(water)") { Description = "Send the player Water Art Card Sleeves", Category = "Items" },
                new("Give Wind Art Card Sleeves", "give_card_sleeves_(wind)") { Description = "Send the player Wind Art Card Sleeves", Category = "Items" },
                new("Give Playmat (Clamigo)", "give_playmat_(clamigo)") { Description = "Send the player a Clamingo Playmat", Category = "Items" },
                new("Give Playmat (Duel)", "give_playmat_(duel)") { Description = "Send the player a Duel Playmat", Category = "Items" },
                new("Give Playmat (Drilceros)", "give_playmat_(drilceros)") { Description = "Send the player a Drilceros Playmat", Category = "Items" },
                new("Give Playmat (Drakon)", "give_playmat_(drakon)") { Description = "Send the player a Drakon Playmat", Category = "Items" },
                new("Give Playmat (The Four Dragons)", "give_playmat_(the_four_dragons)") { Description = "Send the player a The Four Dragons Playmat", Category = "Items" },
                new("Give Playmat (Dracunix)", "give_playmat_(dracunix)") { Description = "Send the player a Dracunix Playmat", Category = "Items" },
                new("Give Playmat (Wispo)", "give_playmat_(wispo)") { Description = "Send the player a Wispo Playmat", Category = "Items" },
                new("Give Playmat (GigatronX Evo)", "give_playmat_(gigatronx_evo)") { Description = "Send the player a GigatronX Evo Playmat", Category = "Items" },
                new("Give Playmat (Tetramon)", "give_playmat_(tetramon)") { Description = "Send the player a Tetramon Playmat", Category = "Items" },
                new("Give Playmat (Kyrone)", "give_playmat_(kyrone)") { Description = "Send the player a Kyrone Playmat", Category = "Items" },
                new("Give Playmat (Fire)", "give_playmat_(fire)") { Description = "Send the player a Fire Playmat", Category = "Items" },
                new("Give Playmat (Earth)", "give_playmat_(earth)") { Description = "Send the player a Earth Playmat", Category = "Items" },
                new("Give Playmat (Water)", "give_playmat_(water)") { Description = "Send the player a Water Playmat", Category = "Items" },
                new("Give Playmat (Wind)", "give_playmat_(wind)") { Description = "Send the player a Wind Playmat", Category = "Items" },
                new("Give Playmat (Lunight)", "give_playmat_(lunight)") { Description = "Send the player a Lunight Playmat", Category = "Items" },


                //new("Spawn 32 Common Packs on Player", "giveatplayer_common_pack_(32)") { Description = "Send the player a Common Pack (32) at their feet.", Category = "Player Spawn" },
                new("Spawn 64 Common Packs on Player", "giveatplayer_common_pack_(64)") { Description = "Send the player a Common Pack (64) at their feet.", Category = "Player Spawn" },
                //new("Spawn Common Box (4) on Player", "giveatplayer_common_box_(4)") { Description = "Send the player a Common Box (4) at their feet.", Category = "Player Spawn" },
                new("Spawn Common Box (8) on Player", "giveatplayer_common_box_(8)") { Description = "Send the player a Common Box (8) at their feet.", Category = "Player Spawn" },
                //new("Spawn Rare Pack (32) on Player", "giveatplayer_rare_pack_(32)") { Description = "Send the player a Rare Pack (32) at their feet.", Category = "Player Spawn" },
                new("Spawn Rare Pack (64) on Player", "giveatplayer_rare_pack_(64)") { Description = "Send the player a Rare Pack (64) at their feet.", Category = "Player Spawn" },
                //new("Spawn Rare Box (4) on Player", "giveatplayer_rare_box_(4)") { Description = "Send the player a Rare Box (4) at their feet.", Category = "Player Spawn" },
                new("Spawn Rare Box (8) on Player", "giveatplayer_rare_box_(8)") { Description = "Send the player a Rare Box (8) at their feet.", Category = "Player Spawn" },
                //new("Spawn Epic Pack (32) on Player", "giveatplayer_epic_pack_(32)") { Description = "Send the player an Epic Pack (32) at their feet.", Category = "Player Spawn" },
                new("Spawn Epic Pack (64) on Player", "giveatplayer_epic_pack_(64)") { Description = "Send the player an Epic Pack (64) at their feet.", Category = "Player Spawn" },
                //new("Spawn Epic Box (4) on Player", "giveatplayer_epic_box_(4)") { Description = "Send the player an Epic Box (4) at their feet.", Category = "Player Spawn" },
                new("Spawn Epic Box (8) on Player", "giveatplayer_epic_box_(8)") { Description = "Send the player an Epic Box (8) at their feet.", Category = "Player Spawn" },
                //new("Spawn Legend Pack (32) on Player", "giveatplayer_legend_pack_(32)") { Description = "Send the player a Legend Pack (32) at their feet.", Category = "Player Spawn" },
                new("Spawn Legend Pack (64) on Player", "giveatplayer_legend_pack_(64)") { Description = "Send the player a Legend Pack (64) at their feet.", Category = "Player Spawn" },
                //new("Spawn Legend Box (4) on Player", "giveatplayer_legend_box_(4)") { Description = "Send the player a Legend Box (4) at their feet.", Category = "Player Spawn" },
                new("Spawn Legend Box (8) on Player", "giveatplayer_legend_box_(8)") { Description = "Send the player a Legend Box (8) at their feet.", Category = "Player Spawn" },
                //new("Spawn Deck Box Red (Small Box) on Player", "giveatplayer_deck_box_red_(sm)") { Description = "Send the player a Red Deck box (Small) at their feet.", Category = "Player Spawn" },
                new("Spawn Deck Box Red (Large Box) on Player", "giveatplayer_deck_box_red") { Description = "Send the player a Red Deck Box (Large) at their feet.", Category = "Player Spawn" },
                //new("Spawn Deck Box Green (Small Box) on Player", "giveatplayer_deck_box_green_(sm)") { Description = "Send the player a Green Deck Box (Small) at their feet.", Category = "Player Spawn" },
                new("Spawn Deck Box Green (Large Box) on Player", "giveatplayer_deck_box_green") { Description = "Send the player a Green Deck Box (Large) at their feet.", Category = "Player Spawn" },
                //new("Spawn Deck Box Blue (Small Box) on Player", "giveatplayer_deck_box_blue_(sm)") { Description = "Send the player a Blue Deck Box (Small) at their feet.", Category = "Player Spawn" },
                new("Spawn Deck Box Blue (Large Box) on Player", "giveatplayer_deck_box_blue") { Description = "Send the player a Blue Deck Box (Large) at their feet.", Category = "Player Spawn" },
                //new("Spawn Deck Box Yellow (Small Box) on Player", "giveatplayer_deck_box_yellow_(sm)") { Description = "Send the player a Yellow Deck Box (Small) at their feet.", Category = "Player Spawn" },
                new("Spawn Deck Box Yellow (Large Box) on Player", "giveatplayer_deck_box_yellow") { Description = "Send the player a Yellow Deck Box (Large) at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Common Pack (32) on Player", "giveatplayer_destiny_common_pack_(32)") { Description = "Send the player a Destiny Common Pack (32) Box at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Common Pack (64) on Player", "giveatplayer_destiny_common_pack_(64)") { Description = "Send the player a Destiny Common Pack (64) Box at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Common Box (4 Packs) on Player", "giveatplayer_destiny_common_box_(4)") { Description = "Send the player a Destiny Common Box (4) at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Common Box (8 Packs) on Player", "giveatplayer_destiny_common_box_(8)") { Description = "Send the player a Destiny Common Box (8) at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Rare Pack (32) on Player", "giveatplayer_destiny_rare_pack_(32)") { Description = "Send the player a Destiny Rare Pack (32) Box at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Rare Pack (64) on Player", "giveatplayer_destiny_rare_pack_(64)") { Description = "Send the player a Destiny Rare Pack (64) Box at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Rare Box (4 Packs) on Player", "giveatplayer_destiny_rare_box_(4)") { Description = "Send the player a Destiny Rare Box (4) at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Rare Box (8) on Player", "giveatplayer_destiny_rare_box_(8)") { Description = "Send the player a Destiny Rare Box (8) at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Epic Pack (32) on Player", "giveatplayer_destiny_epic_pack_(32)") { Description = "Send the player a Destiny Epic Pack (32) Box at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Epic Pack (64) on Player", "giveatplayer_destiny_epic_pack_(64)") { Description = "Send the player a Destiny Epic Pack (64) Box at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Epic Box (4 Packs) on Player", "giveatplayer_destiny_epic_box_(4)") { Description = "Send the player a Destiny Epic Box (4) Packs at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Epic Box (8 Packs) on Player", "giveatplayer_destiny_epic_box_(8)") { Description = "Send the player a Destiny Epic Box (8) Packs at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Legend Pack (32) on Player", "giveatplayer_destiny_legend_pack_(32)") { Description = "Send the player a Destiny Legend Pack (32) Box at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Legend Pack (64) on Player", "giveatplayer_destiny_legend_pack_(64)") { Description = "Send the player a Destiny Legend Pack (64) Box at their feet.", Category = "Player Spawn" },
                //new("Spawn Destiny Legend Box (4) on Player", "giveatplayer_destiny_legend_box_(4)") { Description = "Send the player a Destiny Legend Box (4) Packs at their feet.", Category = "Player Spawn" },
                new("Spawn Destiny Legend Box (8) on Player", "giveatplayer_destiny_legend_box_(8)") { Description = "Send the player a Destiny Legend Box (8) Packs at their feet.", Category = "Player Spawn" },
                //new("Spawn Cleanser (16) on Player", "giveatplayer_cleanser_(16)") { Description = "Send the player a Cleanser pack of 16 at their feet.", Category = "Player Spawn" },
                new("Spawn Cleanser (32) on Player", "giveatplayer_cleanser_(32)") { Description = "Send the player a Cleanser pack of 32 at their feet.", Category = "Player Spawn" },
                new("Spawn Collection Book on Player", "giveatplayer_collection_book") { Description = "Send the player a Collection Book at their feet.", Category = "Player Spawn" },
                new("Spawn D20 Red Dice on Player", "giveatplayer_d20_dice_red") { Description = "Send the player D20 Red Dice at their feet.", Category = "Player Spawn" },
                new("Spawn D20 Blue Dice on Player", "giveatplayer_d20_dice_blue") { Description = "Send the player D20 Blue Dice at their feet.", Category = "Player Spawn" },
                new("Spawn D20 Black Dice on Player", "giveatplayer_d20_dice_black") { Description = "Send the player D20 Black Dice at their feet.", Category = "Player Spawn" },
                new("Spawn D20 White Dice on Player", "giveatplayer_d20_dice_white") { Description = "Send the player D20 White Dice at their feet.", Category = "Player Spawn" },
                new("Spawn Piggy Plushie on Player", "giveatplayer_piggya_plushie") { Description = "Send the player a Piggy Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Golem Plushie on Player", "giveatplayer_golema_plushie") { Description = "Send the player a Golem Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Starfish Plushie on Player", "giveatplayer_starfisha_plushie") { Description = "Send the player a Starfish Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Bat Plushie on Player", "giveatplayer_bata_plushie") { Description = "Send the player a Bat Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Toon Plushie on Player", "giveatplayer_toonz_plushie") { Description = "Send the player a Toon Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Kingstar Plushie on Player", "giveatplayer_kingstar_plushie") { Description = "Send the player a Kingstar Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Bonfiox Plushie on Player", "giveatplayer_bonfiox_plushie") { Description = "Send the player a Bonfiox Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Burpig Figurine on Player", "giveatplayer_burpig_figurine") { Description = "Send the player a Burpig Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Inferhog Figurine on Player", "giveatplayer_inferhog_figurine") { Description = "Send the player a Inferhog Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Blazoar Plushie on Player", "giveatplayer_blazoar_plushie") { Description = "Send the player a Blazoar Plushie at their feet.", Category = "Player Spawn" },
                new("Spawn Decimite Figurine on Player", "giveatplayer_decimite_figurine") { Description = "Send the player a Decimite Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Meganite Figurine on Player", "giveatplayer_meganite_figurine") { Description = "Send the player a Meganite Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Giganite Statue on Player", "giveatplayer_giganite_statue") { Description = "Send the player a Giganite Statue at their feet.", Category = "Player Spawn" },
                new("Spawn Trickstar Figurine on Player", "giveatplayer_trickstar_figurine") { Description = "Send the player a Trickstar Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Princestar Figurine on Player", "giveatplayer_princestar_figurine") { Description = "Send the player a Princestar Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Lunight Figurine on Player", "giveatplayer_lunight_figurine") { Description = "Send the player a Lunight Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Vampicant Figurine on Player", "giveatplayer_vampicant_figurine") { Description = "Send the player a Vampicant Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Dracunix Figurine on Player", "giveatplayer_dracunix_figurine") { Description = "Send the player a Dracunix Figurine at their feet.", Category = "Player Spawn" },
                new("Spawn Drilceros Action Figure on Player", "giveatplayer_drilceros_action_figure") { Description = "Send the player a Drilceros Action Figure at their feet.", Category = "Player Spawn" },
                new("Spawn Fire Battle Deck on Player", "giveatplayer_fire_battle_deck") { Description = "Send the player a Fire Battle Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Earth Battle Deck on Player", "giveatplayer_earth_battle_deck") { Description = "Send the player a Earth Battle Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Water Battle Deck on Player", "giveatplayer_water_battle_deck") { Description = "Send the player a Water Battle Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Wind Battle Deck on Player", "giveatplayer_wind_battle_deck") { Description = "Send the player a Wind Battle Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Fire Destiny Deck on Player", "giveatplayer_fire_destiny_deck") { Description = "Send the player a Fire Destiny Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Earth Destiny Deck on Player", "giveatplayer_earth_destiny_deck") { Description = "Send the player a Earth Destiny Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Water Destiny Deck on Player", "giveatplayer_water_destiny_deck") { Description = "Send the player a Water Destiny Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Wind Destiny Deck on Player", "giveatplayer_wind_destiny_deck") { Description = "Send the player a Wind Destiny Deck at their feet.", Category = "Player Spawn" },
                new("Spawn Clear Card Sleeves on Player", "giveatplayer_card_sleeves_(clear)") { Description = "Send the player Clear Card Sleeves at their feet.", Category = "Player Spawn" },
                new("Spawn Tetramon Style Card Sleeves on Player", "giveatplayer_card_sleeves_(tetramon)") { Description = "Send the player Tetramon Card Sleeves at their feet.", Category = "Player Spawn" },
                new("Spawn Fire Art Card Sleeves on Player", "giveatplayer_card_sleeves_(fire)") { Description = "Send the player Fire Art Card Sleeves at their feet.", Category = "Player Spawn" },
                new("Spawn Earth Art Card Sleeves on Player", "giveatplayer_card_sleeves_(earth)") { Description = "Send the player Earth Art Card Sleeves at their feet.", Category = "Player Spawn" },
                new("Spawn Water Art Card Sleeves on Player", "giveatplayer_card_sleeves_(water)") { Description = "Send the player Water Art Card Sleeves at their feet.", Category = "Player Spawn" },
                new("Spawn Wind Art Card Sleeves on Player", "giveatplayer_card_sleeves_(wind)") { Description = "Send the player Wind Art Card Sleeves at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Clamigo) on Player", "giveatplayer_playmat_(clamigo)") { Description = "Send the player a Clamingo Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Duel) on Player", "giveatplayer_playmat_(duel)") { Description = "Send the player a Duel Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Drilceros) on Player", "giveatplayer_playmat_(drilceros)") { Description = "Send the player a Drilceros Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Drakon) on Player", "giveatplayer_playmat_(drakon)") { Description = "Send the player a Drakon Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (The Four Dragons) on Player", "giveatplayer_playmat_(the_four_dragons)") { Description = "Send the player a The Four Dragons Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Dracunix) on Player", "giveatplayer_playmat_(dracunix)") { Description = "Send the player a Dracunix Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Wispo) on Player", "giveatplayer_playmat_(wispo)") { Description = "Send the player a Wispo Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (GigatronX Evo) on Player", "giveatplayer_playmat_(gigatronx_evo)") { Description = "Send the player a GigatronX Evo Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Tetramon) on Player", "giveatplayer_playmat_(tetramon)") { Description = "Send the player a Tetramon Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Kyrone) on Player", "giveatplayer_playmat_(kyrone)") { Description = "Send the player a Kyrone Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Fire) on Player", "giveatplayer_playmat_(fire)") { Description = "Send the player a Fire Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Earth) on Player", "giveatplayer_playmat_(earth)") { Description = "Send the player a Earth Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Water) on Player", "giveatplayer_playmat_(water)") { Description = "Send the player a Water Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Wind) on Player", "giveatplayer_playmat_(wind)") { Description = "Send the player a Wind Playmat at their feet.", Category = "Player Spawn" },
                new("Spawn Playmat (Lunight) on Player", "giveatplayer_playmat_(lunight)") { Description = "Send the player a Lunight Playmat at their feet.", Category = "Player Spawn" },


                new("High FOV", "highfov") { Description = "Set the FOV for the player higher than normal!", Duration = 30, Category = "Game FOV" },
                new("Low FOV", "lowfov") { Description = "Set the FOV for the player lower, giving them tunnel vision!", Duration = 30, Category = "Game FOV" },
                new("Invert X-Axis", "invertx") { Description = "Invert the X-Axis of the players controls!", Duration = 30, Category = "Axis Control" },
                new("Invert Y-Axis", "inverty") { Description = "Invert the Y-Axis of the players controls!", Duration = 30, Category = "Axis Control" },
                new("Set Language to English", "language_english") { Description = "Set Language to English.", Duration = 60, Category = "Game Language" },
                new("Set Language to French", "language_french") { Description = "Set Language to French.", Duration = 60, Category = "Game Language" },
                new("Set Language to German", "language_german") { Description = "Set Language to German.", Duration = 60, Category = "Game Language" },
                new("Set Language to Spanish", "language_spanish") { Description = "Set Language to Spanish.", Duration = 60, Category = "Game Language" },
                new("Set Language to Italian", "language_italian") { Description = "Set Language to Italian.", Duration = 60, Category = "Game Language" },
                new("Set Language to Portuguese (Portugal)", "language_portuguese") { Description = "Set Language to Portuguese (Portugal).", Duration = 60, Category = "Game Language" },
                new("Set Language to Chinese (Simplified)", "language_chineses") { Description = "Set Language to Portuguese (Brazil).", Duration = 60, Category = "Game Language" },
                new("Set Language to Chinese (Traditional)", "language_chineset") { Description = "Set Language to Chinese T.", Duration = 60, Category = "Game Language" },
                new("Set Language to Korean", "language_korean") { Description = "Set Language to Korean.", Duration = 60, Category = "Game Language" },
                new("Set Language to Japanese", "language_japanese") { Description = "Set Language to Japanese.", Duration = 60, Category = "Game Language" },
                new("Set Language to Russian", "language_russian") { Description = "Set Language to Russian.", Duration = 60, Category = "Game Language" },
                new("Set Language to Hindi", "language_hindi") { Description = "Set Language to Hindi.", Duration = 60, Category = "Game Language" },
                new("Set Language to Thai", "language_thai") { Description = "Set Language to Thai.", Duration = 60, Category = "Game Language" },
                new("Set Language to Arabic", "language_arabic") { Description = "Set Language to Arabic.", Duration = 60, Category = "Game Language" },
                new("Set Language to Dutch", "language_dutch") { Description = "Set Language to Dutch.", Duration = 60, Category = "Game Language" },

                new Effect("Hey Ohhh", "speak_heyoo") { Description = "Speak!", Category = "Speak"},


        };
    }
}
