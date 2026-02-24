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
        static const AkUniqueID PLAY_BOXBREAK = 843996146U;
        static const AkUniqueID PLAY_CHESTAVAILABLE = 1067323442U;
        static const AkUniqueID PLAY_CHESTOPEN = 364247913U;
        static const AkUniqueID PLAY_COLLECTEDKEY = 2640353952U;
        static const AkUniqueID PLAY_DEATH = 1172822028U;
        static const AkUniqueID PLAY_DOOROPEN = 3197300806U;
        static const AkUniqueID PLAY_FLOORPLATE = 1263684764U;
        static const AkUniqueID PLAY_FOOTSTEPS = 3854155799U;
        static const AkUniqueID PLAY_JUMP = 3689126666U;
        static const AkUniqueID PLAY_MAINMENUBGM = 1063700270U;
        static const AkUniqueID PLAY_MAINMUSICSWITCH = 3684206702U;
        static const AkUniqueID PLAY_PORTALENTER = 4016738326U;
        static const AkUniqueID PLAY_SPAWN = 1012143543U;
        static const AkUniqueID PLAY_STONEKEY = 3865522774U;
        static const AkUniqueID PLAY_UI_EXIT = 1986548623U;
        static const AkUniqueID PLAY_UI_ONCLICK = 3570890048U;
        static const AkUniqueID PLAY_UI_ONHOVER = 3111063598U;
        static const AkUniqueID PLAY_UI_OPEN = 3905148667U;
        static const AkUniqueID PLAY_UI_STARTGAME = 1473547871U;
        static const AkUniqueID PLAY_WEAPONPICKUP = 594124390U;
        static const AkUniqueID STOP_MAINMENUBGM = 1323942960U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace FOOSTEPSSTATE
        {
            static const AkUniqueID GROUP = 1459258807U;

            namespace STATE
            {
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID STONE = 1216965916U;
                static const AkUniqueID WET = 1181096339U;
            } // namespace STATE
        } // namespace FOOSTEPSSTATE

        namespace LOCATION
        {
            static const AkUniqueID GROUP = 1176052424U;

            namespace STATE
            {
                static const AkUniqueID CAVE = 4122393694U;
                static const AkUniqueID FOREST = 491961918U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID WATER = 2654748154U;
            } // namespace STATE
        } // namespace LOCATION

        namespace MUSICSTATE
        {
            static const AkUniqueID GROUP = 1021618141U;

            namespace STATE
            {
                static const AkUniqueID GAMEPLAY = 89505537U;
                static const AkUniqueID MENU = 2607556080U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace MUSICSTATE

    } // namespace STATES

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
