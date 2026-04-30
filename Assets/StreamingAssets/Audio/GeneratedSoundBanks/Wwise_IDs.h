/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_CAVE_AMBIENCE = 1911082204U;
        static const AkUniqueID PLAY_CHOMPER_ATTACK = 931488463U;
        static const AkUniqueID PLAY_CHOMPER_DEATH = 2761388991U;
        static const AkUniqueID PLAY_CHOMPER_FOOTSTEPS = 3742480528U;
        static const AkUniqueID PLAY_CHOMPER_GROWL = 3523988694U;
        static const AkUniqueID PLAY_CHOMPER_HURT = 749645064U;
        static const AkUniqueID PLAY_DESTRUCTIBLEBOX = 4151201399U;
        static const AkUniqueID PLAY_DOOROPEN = 3197300806U;
        static const AkUniqueID PLAY_ELLEN_ATTACK = 3439843113U;
        static const AkUniqueID PLAY_ELLEN_ATTACK_HIT = 4018741819U;
        static const AkUniqueID PLAY_ELLEN_ATTACK_VO = 2923999633U;
        static const AkUniqueID PLAY_ELLEN_DEATH = 985089565U;
        static const AkUniqueID PLAY_ELLEN_FOOTSTEPS = 3756943418U;
        static const AkUniqueID PLAY_ELLEN_HEAL = 231575099U;
        static const AkUniqueID PLAY_ELLEN_HURT = 519354622U;
        static const AkUniqueID PLAY_ELLEN_JUMP = 756395797U;
        static const AkUniqueID PLAY_ELLEN_LAND_ROLL = 2439963732U;
        static const AkUniqueID PLAY_ELLEN_SHIELDCRACK = 3703199980U;
        static const AkUniqueID PLAY_ELLEN_SPAWN = 3225604978U;
        static const AkUniqueID PLAY_FLOORPLATE_ACTIVATED = 3631107208U;
        static const AkUniqueID PLAY_FOREST_AMBIENCE = 811708576U;
        static const AkUniqueID PLAY_GAMEPLAYBGM = 2227815452U;
        static const AkUniqueID PLAY_GRENADIER_DEATH = 3337034902U;
        static const AkUniqueID PLAY_GRENADIER_FOOTSTEPS = 2094447813U;
        static const AkUniqueID PLAY_GRENADIER_HURT = 3417550891U;
        static const AkUniqueID PLAY_GRENADIER_MELEE = 826593012U;
        static const AkUniqueID PLAY_GRENADIER_RANGE_1 = 1363968655U;
        static const AkUniqueID PLAY_GRENADIER_RANGE_2_AMMO = 2086598241U;
        static const AkUniqueID PLAY_GRENADIER_RANGE_2_THROW = 2696401305U;
        static const AkUniqueID PLAY_HEALTHCRATE_OPEN = 3862797904U;
        static const AkUniqueID PLAY_MAINMENUBGM = 1063700270U;
        static const AkUniqueID PLAY_MOVINGPLATFORM_DOWN = 3679527148U;
        static const AkUniqueID PLAY_MOVINGPLATFORM_UP = 571167591U;
        static const AkUniqueID PLAY_SPITTER_ATTACK = 3913336272U;
        static const AkUniqueID PLAY_SPITTER_ATTACK_SPLAT = 4160876689U;
        static const AkUniqueID PLAY_SWITCH_ACTIVATED = 3572783242U;
        static const AkUniqueID PLAY_SWITCH_IDLE = 3260921235U;
        static const AkUniqueID PLAY_TELEPORT_ENTER = 2317718668U;
        static const AkUniqueID PLAY_TELEPORT_IDLE = 3511716172U;
        static const AkUniqueID PLAY_UI_EXIT = 1986548623U;
        static const AkUniqueID PLAY_UI_ONCLICK = 3570890048U;
        static const AkUniqueID PLAY_UI_ONHOVER = 3111063598U;
        static const AkUniqueID PLAY_UI_OPEN = 3905148667U;
        static const AkUniqueID PLAY_UI_STARTGAME = 1473547871U;
        static const AkUniqueID PLAY_WATER_AMBIENCE = 3130396874U;
        static const AkUniqueID PLAY_WEAPONPICKUP = 594124390U;
        static const AkUniqueID STOP_CAVE_AMBIENCE = 221660262U;
        static const AkUniqueID STOP_FOREST_AMBIENCE = 2989050186U;
        static const AkUniqueID STOP_GAMEPLAYBGM = 4011792610U;
        static const AkUniqueID STOP_MAINMENUBGM = 1323942960U;
        static const AkUniqueID STOP_WATER_AMBIENCE = 4006853768U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace FOOTSTEPSSTATE
        {
            static const AkUniqueID GROUP = 2507554221U;

            namespace STATE
            {
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID STONE = 1216965916U;
                static const AkUniqueID WET = 1181096339U;
            } // namespace STATE
        } // namespace FOOTSTEPSSTATE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace FOOTSTEPS
        {
            static const AkUniqueID GROUP = 2385628198U;

            namespace SWITCH
            {
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID STONE = 1216965916U;
                static const AkUniqueID WET = 1181096339U;
            } // namespace SWITCH
        } // namespace FOOTSTEPS

        namespace PINK_FOOTSTEPS
        {
            static const AkUniqueID GROUP = 927575501U;

            namespace SWITCH
            {
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID STONE = 1216965916U;
                static const AkUniqueID WET = 1181096339U;
            } // namespace SWITCH
        } // namespace PINK_FOOTSTEPS

    } // namespace SWITCHES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
