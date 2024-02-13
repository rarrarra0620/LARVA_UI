using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPLE.App
{
    public class IoValueHelper
    {
        public static bool ON = true;
        public static bool OFF = false;
    }

    public enum eAccessMode
    {
        NONE = 0,
        MANUAL = 1,
        AUTO = 2
    }

    public enum eAvailable
    {
        DOWN = 0,
        UP = 1,
    }

    public enum eAlarm
    {
        NO_ALARM = 0,
        LIGHT = 1,
        HEAVY = 2
    }
    public enum eLedCmd
    {
        NONE = 0,
        OFF = 1,
        ON_50 = 2,
        ON_100 = 3
    }

    public enum eLockUnlock
    {
        NONE = 0,
        UNLOCK = 1,
        LOCK = 2,
        ERROR = 3
    }

    public enum eOnOff
    {
        OFF= 0,
        ON= 1,
    }
    public enum eOpenClose
    {
        CLOSE = 0,
        OPEN = 1,
    }

    public enum eRunStop
    {
        STOP = 0,
        RUN = 1,
    }

    public enum eRunStatus
    {
        IDLE = 0,
        RUNNING = 1,
        PAUSING = 2,
        PAUSED	= 3
    }

    public enum eUpDown
    {
        NONE = 0,
        UP = 1,
        DOWN = 2,
        ERROR = 3
    }

    public enum eFwdBwd
    {
        NONE = 0,
        BACKWARD = 1,
        FORWARD = 2,
        ERROR = 3
    }

    public enum eCoverAction
    {
        NONE = 0,
        OPEN_ACT = 1,
        CLOSE_ACT = 2
    }

    public enum eMotorCmd
    {
        NONE = 0,
        OFF = 1,
        CW	= 2,
        CCW = 3
    }

    public class IoNameHelper
    {
        public static string oEqp_nOp_Mode = "oEqp.nOp.Mode";
        public static string oEqp_nOp_Pause = "oEqp.nOp.Pause";
        public static string oEqp_nAlarm_Reset = "oEqp.nAlarm.Reset";
        public static string oEqp_nBuzzer_Off = "oEqp.nBuzzer.Off";

        public static string oTrans_nMove_Req = "oTrans.nMove.Req";
        public static string oFlop_nProc_Req = "oFlop.nProc.Req";
        public static string oTob_nProc_Req = "oTob.nProc.Req";
        public static string oWash_nProc_Req = "oWash.nProc.Req";
        public static string oHvac_nProc_Req = "oHvac.nProc.Req";
        public static string oMot_nXHome_Req = "oMot.nXHome.Req";
        public static string oMot_nYHome_Req = "oMot.nYHome.Req";
        public static string oMot_nZHome_Req = "oMot.nZHome.Req";
        public static string oMot_nFlipHome_Req = "oMot.nFlipHome.Req";
        public static string oMain_nDoor_OpnCls = "oMain.nDoor.OpnCls";
        public static string oHvac_nCtrl_OnOff = "oHvac.nCtrl.OnOff";
        public static string oLoader_nShutter_UpDown = "oLoader.nShutter.UpDown";
        public static string oLoader_nShuttle_FwdBwd = "oLoader.nShuttle.FwdBwd";
        public static string oLoader_nLED_OnOff = "oLoader.nLED.OnOff";
        public static string oWash_nLED_OnOff = "oWash.nLED.OnOff";
        public static string oLed_nZone1_OnOff = "oLed.nZone1.OnOff";
        public static string oLed_nZone2_OnOff = "oLed.nZone2.OnOff";
        public static string oLed_nZone3_OnOff = "oLed.nZone3.OnOff";
        public static string oLed_nZone4_OnOff = "oLed.nZone4.OnOff";
        public static string oLed_nZone5_OnOff = "oLed.nZone5.OnOff";
        public static string oLed_nZone6_OnOff = "oLed.nZone6.OnOff";
        public static string oLed_nZone7_OnOff = "oLed.nZone7.OnOff";
        public static string oLed_nZone8_OnOff = "oLed.nZone8.OnOff";
        public static string oFlip_nUpperCover_UpDown = "oFlip.nUpperCover.UpDown";
        public static string oFlip_nImpCyl_L1_FwdBwd = "oFlip.nImpCyl_L1.FwdBwd";
        public static string oFlip_nImpCyl_L2_FwdBwd = "oFlip.nImpCyl_L2.FwdBwd";
        public static string oFlip_nBoxImpact_RunStop = "oFlip.nBoxImpact.RunStop";
        public static string oFlip_nOutConv_OnOff = "oFlip.nOutConv.OnOff";
        public static string oFlip_nOutShutter_UpDown = "oFlip.nOutShutter.UpDown";
        public static string oTBS_nHopper_Motor = "oTBS.nHopper.Motor";
        public static string oHotAir_nBlower_OnOff = "oHotAir.nBlower.OnOff";
        public static string oTBS_nUVLamp_OnOff = "oTBS.nUVLamp.OnOff";
        public static string oTBS_nMist_OnOff = "oTBS.nMist.OnOff";
        public static string oTBS_nMixer_Motor = "oTBS.nMixer.Motor";
        public static string oTBS_nFlatCyl_RunStop = "oTBS.nFlatCyl.RunStop";
        public static string oTBS_nFlatMotor_RunStop = "oTBS.nFlatMotor.RunStop";
        public static string oTBS_nSwingCyl_RunStop = "oTBS.nSwingCyl.RunStop";
        public static string oWash_nWaterPump_OnOff = "oWash.nWaterPump.OnOff";
        public static string oWash_nTankValve_OnOff = "oWash.nTankValve.OnOff";
        public static string oWash_nWaterValve_OnOff = "oWash.nWaterValve.OnOff";
        public static string oAir_nCirculatorFan_OnOff = "oAir.nCirculatorFan.OnOff";
        public static string oTrans_nMove_RunStop = "oTrans.nMove.RunStop";
        public static string oTrans_nPick_RunStop = "oTrans.nPick.RunStop";
        public static string oTrans_nPlace_RunStop = "oTrans.nPlace.RunStop";
        public static string oTrans_nHand_LeftRight = "oTrans.nHand.LeftRight";
        public static string oTrans_BoxClamp_LockUnlock = "oTrans.BoxClamp.LockUnlock";
        public static string oTrans_nBoxCover_UpDown = "oTrans.nBoxCover.UpDown";
        public static string oTrans_nCoverVac_OnOff = "oTrans.nCoverVac.OnOff";
        public static string oTrans_nCoverVacEject_OnOFF = "oTrans.nCoverVacEject.OnOFF";

        public static string oAmmo_nExhaustFan_OnOff = "oAmmo.nExhaustFan.OnOff";
        public static string oAuto_nTobbabSupply_Req = "oAuto.nTobbabSupply.Req";
        public static string oAuto_nTobbabChange_Req = "oAuto.nTobbabChange.Req";
        public static string oAuto_nJellySupply_Req = "oAuto.nJellySupply.Req";
        public static string oAuto_nRiceSupply_Req = "oAuto.nRiceSupply.Req";
        public static string oAuto_nFeedStop_Req = "oAuto.nFeedStop.Req";
        public static string oAuto_nVision_Req = "oAuto.nVision.Req";
        public static string oAuto_nLoad_Req = "oAuto.nLoad.Req";
        public static string oAuto_nUnload_Req = "oAuto.nUnload.Req";
        public static string oAuto_nMist_Req = "oAuto.nMist.Req";
        public static string oAuto_nShipment_Req = "oAuto.nShipment.Req";
        public static string oAuto_nEject_Req = "oAuto.nEject.Req";
        public static string oAuto_nLoadComplete_Reply = "oAuto.nLoadComplete.Reply";
        public static string oAuto_nVisionComplete_Reply = "oAuto.nVisionComplete.Reply";
        public static string oParam_nPick_LocationId = "oParam.nPick.LocationId";
        public static string oParam_nPlace_LocationId = "oParam.nPlace.LocationId";
        public static string oParam_nPostPick_CoverAct = "oParam.nPostPick.CoverAct";
        public static string oParam_nPrePlace_CoverAct = "oParam.nPrePlace.CoverAct";
        public static string oParam_nTransMove_LocationId = "oParam.nTransMove.LocationId";
        public static string oParam_nBoxImpact_Duration = "oParam.nBoxImpact.Duration";
        public static string oParam_nOutConv_Duration = "oParam.nOutConv.Duration";
        public static string oParam_nFlipSwing_Duration = "oParam.nFlipSwing.Duration";
        public static string oParam_nTobbab_Weight = "oParam.nTobbab.Weight";
        public static string oParam_nWash_Duration = "oParam.nWash.Duration";
        public static string oParam_fHvac_TargetTemp = "oParam.fHvac.TargetTemp";
        public static string oParam_fHvac_TargetHumidity = "oParam.fHvac.TargetHumidity";
        public static string oParam_nMist_Duration = "oParam.nMist.Duration";
        public static string oParam_nTargetBox_LocationId = "oParam.nTargetBox.LocationId";


        public static string iEqp_nOp_Mode = "iEqp.nOp.Mode";
        public static string iEqp_nAvailable_Status = "iEqp.nAvailable.Status";
        public static string iEqp_nAlarm_Status = "iEqp.nAlarm.Status";
        public static string iEqp_nInterlock_Status = "iEqp.nInterlock.Status";
        public static string iEqp_nRun_Status = "iEqp.nRun.Status";
        public static string iTrans_nMove_Reply = "iTrans.nMove.Reply";
        public static string iTrans_nMove_Busy = "iTrans.nMove.Busy";
        public static string iFlip_nProc_Reply = "iFlip.nProc.Reply";
        public static string iFlip_nProc_Busy = "iFlip.nProc.Busy";
        public static string iTob_nProc_Reply = "iTob.nProc.Reply";
        public static string iTob_nProc_Busy = "iTob.nProc.Busy";
        public static string iWash_nProc_Reply = "iWash.nProc.Reply";
        public static string iWash_nProc_Busy = "iWash.nProc.Busy";
        public static string iHvac_nProc_Reply = "iHvac.nProc.Reply";
        public static string iHvac_nProc_Busy = "iHvac.nProc.Busy";
        public static string iMot_nXHome_Reply = "iMot.nXHome.Reply";
        public static string iMot_nXHome_Busy = "iMot.nXHome.Busy";
        public static string iMot_nYHome_Reply = "iMot.nYHome.Reply";
        public static string iMot_nYHome_Busy = "iMot.nYHome.Busy";
        public static string iMot_nZHome_Reply = "iMot.nZHome.Reply";
        public static string iMot_nZHome_Busy = "iMot.nZHome.Busy";
        public static string iMot_nFlipHome_Reply = "iMot.nFlipHome.Reply";
        public static string iMot_nFlipHome_Busy = "iMot.nFlipHome.Busy";
        public static string iAuto_nTobbabSupply_Reply = "iAuto.nTobbabSupply.Reply";
        public static string iAuto_nTobbabSupply_Busy = "iAuto.nTobbabSupply.Busy";
        public static string iAuto_nTobbabChange_Reply = "iAuto.nTobbabChange.Reply";
        public static string iAuto_nTobbabChange_Busy = "iAuto.nTobbabChange.Busy";
        public static string iAuto_nJellySupply_Reply = "iAuto.nJellySupply.Reply";
        public static string iAuto_nJellySupply_Busy = "iAuto.nJellySupply.Busy";
        public static string iAuto_nRiceSupply_Reply = "iAuto.nRiceSupply.Reply";
        public static string iAuto_nRiceSupply_Busy = "iAuto.nRiceSupply.Busy";
        public static string iAuto_nFeedStop_Reply = "iAuto.nFeedStop.Reply";
        public static string iAuto_nFeedStop_Busy = "iAuto.nFeedStop.Busy";
        public static string iAuto_nVision_Reply = "iAuto.nVision.Reply";
        public static string iAuto_nVision_Busy = "iAuto.nVision.Busy";
        public static string iAuto_nLoad_Reply = "iAuto.nLoad.Reply";
        public static string iAuto_nLoad_Busy = "iAuto.nLoad.Busy";
        public static string iAuto_nUnload_Reply = "iAuto.nUnload.Reply";
        public static string iAuto_nUnload_Busy = "iAuto.nUnload.Busy";
        public static string iAuto_nMist_Reply = "iAuto.nMist.Reply";
        public static string iAuto_nMist_Busy = "iAuto.nMist.Busy";
        public static string iAuto_nShipment_Reply = "iAuto.nShipment.Reply";
        public static string iAuto_nShipment_Busy = "iAuto.nShipment.Busy";
        public static string iAuto_nEject_Reply = "iAuto.nEject.Reply";
        public static string iAuto_nEject_Busy = "iAuto.nEject.Busy";
        public static string iAuto_nLoadComplete_Req = "iAuto.nLoadComplete.Req";
        public static string iAuto_nVisionComplete_Req = "iAuto.nVisionComplete.Req";
        public static string iHotAir_fBlower_Temp = "iHotAir.fBlower.Temp";
        public static string iLoadcell_fWeight_Value = "iLoadcell.fWeight.Value";
        public static string iTH_fCurrent_Temp = "iTH.fCurrent.Temp";
        public static string iTH_fCurrent_Humidity = "iTH.fCurrent.Humidity";
        public static string iHvac_nFan_Status = "iHvac.nFan.Status";
        public static string iHvac_nCooling_Status = "iHvac.nCooling.Status";
        public static string iHvac_nHeating_Status = "iHvac.nHeating.Status";
        public static string iHvac_nHumidify_Status = "iHvac.nHumidify.Status";
        public static string iHvac_nDehumidify_Status = "iHvac.nDehumidify.Status";
        public static string iHvac_nAlarm_Status = "iHvac.nAlarm.Status";
        public static string iHvac_fCurrent_Temp = "iHvac.fCurrent.Temp";
        public static string iHvac_fCurrent_Humidity = "iHvac.fCurrent.Humidity";
        public static string iMain_nDoor_Open = "iMain.nDoor.Open";
        public static string iMixer_nDoor_Open = "iMixer.nDoor.Open";
        public static string iEmo_nIn_SwitchOn = "iEmo.nIn.SwitchOn";
        public static string iEmo_nOut_SwitchOn = "iEmo.nOut.SwitchOn";
        public static string iAir_nMainSupply_Valve = "iAir.nMainSupply.Valve";
        public static string iLoader_nShutter_UpDown = "iLoader.nShutter.UpDown";
        public static string iLoader_nShuttle_FwdBwd = "iLoader.nShuttle.FwdBwd";
        public static string iLoader_nBox_CheckSns = "iLoader.nBox.CheckSns";
        public static string iBuffer_nBox_Check_Sns = "iBuffer.nBox.Check.Sns";
        public static string iFlip_nBox_Check_Sns = "iFlip.nBox.Check.Sns";
        public static string iFlip_nUpperCover_UpDown = "iFlip.nUpperCover.UpDown";
        public static string iFlip_nImpCyl_L1_FwdBwd = "iFlip.nImpCyl_L1.FwdBwd";
        public static string iFlip_nImpCyl_L2_FwdBwd = "iFlip.nImpCyl_L2.FwdBwd";
        public static string iFlip_nImpCyl_R1_FwdBwd = "iFlip.nImpCyl_R1.FwdBwd";
        public static string iFlip_nImpCyl_R2_FwdBwd = "iFlip.nImpCyl_R2.FwdBwd";
        public static string iFlip_nOutShutter_UpDown = "iFlip.nOutShutter.UpDown";
        public static string iTrans_nClamp_LockUnlock = "iTrans.nClamp.LockUnlock";
        public static string iTrans_nHandLeft_FwdBwd = "iTrans.nHandLeft.FwdBwd";
        public static string iTrans_nBoxCover_UpDown = "iTrans.nBoxCover.UpDown";
        public static string iTrans_nBoxCoverVac_OnOff = "iTrans.nBoxCoverVac.OnOff";
        public static string iTrans_nHandLeftBox_CheckSns = "iTrans.nHandLeftBox.CheckSns";
        public static string iTrans_nHandRightBox_CheckSns = "iTrans.nHandRightBox.CheckSns";
        public static string iWash_nBox_CheckSns = "iWash.nBox.CheckSns";
        public static string iWash_nTankHi_LimitSns = "iWash.nTankHi.LimitSns";
        public static string iWash_nTankLo_LimitSns = "iWash.nTankLo.LimitSns";
        public static string iWash_nTank_FullSns = "iWash.nTank.FullSns";
        public static string iWash_nDrain_BlockSns = "iWash.nDrain.BlockSns";
        public static string iTBS_nBox_CheckSns = "iTBS.nBox.CheckSns";
        public static string iTBS_nFlatMotPositive_LimitSns = "iTBS.nFlatMotPositive.LimitSns";
        public static string iTBS_nFlatMotNegative_LimitSns = "iTBS.nFlatMotNegative.LimitSns";
        public static string iTBS_nFlatCyl_FwdBwd = "iTBS.nFlatCyl.FwdBwd";
        public static string iTBS_nSwingCyl_FwdBwd = "iTBS.nSwingCyl.FwdBwd";
        public static string iVision_nBox_CheckSns = "iVision.nBox.CheckSns";
        public static string iTrans_nServoX_HomeSns = "iTrans.nServoX.HomeSns";
        public static string iTrans_nServoZ_HomeSns = "iTrans.nServoZ.HomeSns";
        public static string iTrans_nServoY_HomeSns = "iTrans.nServoY.HomeSns";
        public static string iTrans_nServoFlip_HomeSns = "iTrans.nServoFlip.HomeSns";
        public static string iStock_nBox_111F = "iStock.nBox.111F";
        public static string iStock_nBox_111R = "iStock.nBox.111R";
        public static string iStock_nBox_112F = "iStock.nBox.112F";
        public static string iStock_nBox_112R = "iStock.nBox.112R";
        public static string iStock_nBox_113F = "iStock.nBox.113F";
        public static string iStock_nBox_113R = "iStock.nBox.113R";
        public static string iStock_nBox_121F = "iStock.nBox.121F";
        public static string iStock_nBox_121R = "iStock.nBox.121R";
        public static string iStock_nBox_122F = "iStock.nBox.122F";
        public static string iStock_nBox_122R = "iStock.nBox.122R";
        public static string iStock_nBox_123F = "iStock.nBox.123F";
        public static string iStock_nBox_123R = "iStock.nBox.123R";
        public static string iStock_nBox_131F = "iStock.nBox.131F";
        public static string iStock_nBox_131R = "iStock.nBox.131R";
        public static string iStock_nBox_132F = "iStock.nBox.132F";
        public static string iStock_nBox_132R = "iStock.nBox.132R";
        public static string iStock_nBox_133F = "iStock.nBox.133F";
        public static string iStock_nBox_133R = "iStock.nBox.133R";
        public static string iStock_nBox_141F = "iStock.nBox.141F";
        public static string iStock_nBox_141R = "iStock.nBox.141R";
        public static string iStock_nBox_142F = "iStock.nBox.142F";
        public static string iStock_nBox_142R = "iStock.nBox.142R";
        public static string iStock_nBox_143F = "iStock.nBox.143F";
        public static string iStock_nBox_143R = "iStock.nBox.143R";
        public static string iStock_nBox_151F = "iStock.nBox.151F";
        public static string iStock_nBox_151R = "iStock.nBox.151R";
        public static string iStock_nBox_152F = "iStock.nBox.152F";
        public static string iStock_nBox_152R = "iStock.nBox.152R";
        public static string iStock_nBox_153F = "iStock.nBox.153F";
        public static string iStock_nBox_153R = "iStock.nBox.153R";
        public static string iStock_nBox_211F = "iStock.nBox.211F";
        public static string iStock_nBox_211R = "iStock.nBox.211R";
        public static string iStock_nBox_212F = "iStock.nBox.212F";
        public static string iStock_nBox_212R = "iStock.nBox.212R";
        public static string iStock_nBox_213F = "iStock.nBox.213F";
        public static string iStock_nBox_213R = "iStock.nBox.213R";
        public static string iStock_nBox_221F = "iStock.nBox.221F";
        public static string iStock_nBox_221R = "iStock.nBox.221R";
        public static string iStock_nBox_222F = "iStock.nBox.222F";
        public static string iStock_nBox_222R = "iStock.nBox.222R";
        public static string iStock_nBox_223F = "iStock.nBox.223F";
        public static string iStock_nBox_223R = "iStock.nBox.223R";
        public static string iStock_nBox_231F = "iStock.nBox.231F";
        public static string iStock_nBox_231R = "iStock.nBox.231R";
        public static string iStock_nBox_232F = "iStock.nBox.232F";
        public static string iStock_nBox_232R = "iStock.nBox.232R";
        public static string iStock_nBox_233F = "iStock.nBox.233F";
        public static string iStock_nBox_233R = "iStock.nBox.233R";
        public static string iStock_nBox_241F = "iStock.nBox.241F";
        public static string iStock_nBox_241R = "iStock.nBox.241R";
        public static string iStock_nBox_242F = "iStock.nBox.242F";
        public static string iStock_nBox_242R = "iStock.nBox.242R";
        public static string iStock_nBox_243F = "iStock.nBox.243F";
        public static string iStock_nBox_243R = "iStock.nBox.243R";
        public static string iStock_nBox_251F = "iStock.nBox.251F";
        public static string iStock_nBox_251R = "iStock.nBox.251R";
        public static string iStock_nBox_252F = "iStock.nBox.252F";
        public static string iStock_nBox_252R = "iStock.nBox.252R";
        public static string iStock_nBox_253F = "iStock.nBox.253F";
        public static string iStock_nBox_253R = "iStock.nBox.253R";
        public static string iStock_nBox_311F = "iStock.nBox.311F";
        public static string iStock_nBox_311R = "iStock.nBox.311R";
        public static string iStock_nBox_312F = "iStock.nBox.312F";
        public static string iStock_nBox_312R = "iStock.nBox.312R";
        public static string iStock_nBox_313F = "iStock.nBox.313F";
        public static string iStock_nBox_313R = "iStock.nBox.313R";
        public static string iStock_nBox_321F = "iStock.nBox.321F";
        public static string iStock_nBox_321R = "iStock.nBox.321R";
        public static string iStock_nBox_322F = "iStock.nBox.322F";
        public static string iStock_nBox_322R = "iStock.nBox.322R";
        public static string iStock_nBox_323F = "iStock.nBox.323F";
        public static string iStock_nBox_323R = "iStock.nBox.323R";
        public static string iStock_nBox_331F = "iStock.nBox.331F";
        public static string iStock_nBox_331R = "iStock.nBox.331R";
        public static string iStock_nBox_332F = "iStock.nBox.332F";
        public static string iStock_nBox_332R = "iStock.nBox.332R";
        public static string iStock_nBox_333F = "iStock.nBox.333F";
        public static string iStock_nBox_333R = "iStock.nBox.333R";
        public static string iStock_nBox_341F = "iStock.nBox.341F";
        public static string iStock_nBox_341R = "iStock.nBox.341R";
        public static string iStock_nBox_342F = "iStock.nBox.342F";
        public static string iStock_nBox_342R = "iStock.nBox.342R";
        public static string iStock_nBox_343F = "iStock.nBox.343F";
        public static string iStock_nBox_343R = "iStock.nBox.343R";
        public static string iStock_nBox_351F = "iStock.nBox.351F";
        public static string iStock_nBox_351R = "iStock.nBox.351R";
        public static string iStock_nBox_352F = "iStock.nBox.352F";
        public static string iStock_nBox_352R = "iStock.nBox.352R";
        public static string iStock_nBox_353F = "iStock.nBox.353F";
        public static string iStock_nBox_353R = "iStock.nBox.353R";
        public static string iStock_nBox_411F = "iStock.nBox.411F";
        public static string iStock_nBox_411R = "iStock.nBox.411R";
        public static string iStock_nBox_412F = "iStock.nBox.412F";
        public static string iStock_nBox_412R = "iStock.nBox.412R";
        public static string iStock_nBox_413F = "iStock.nBox.413F";
        public static string iStock_nBox_413R = "iStock.nBox.413R";
        public static string iStock_nBox_421F = "iStock.nBox.421F";
        public static string iStock_nBox_421R = "iStock.nBox.421R";
        public static string iStock_nBox_422F = "iStock.nBox.422F";
        public static string iStock_nBox_422R = "iStock.nBox.422R";
        public static string iStock_nBox_423F = "iStock.nBox.423F";
        public static string iStock_nBox_423R = "iStock.nBox.423R";
        public static string iStock_nBox_431F = "iStock.nBox.431F";
        public static string iStock_nBox_431R = "iStock.nBox.431R";
        public static string iStock_nBox_432F = "iStock.nBox.432F";
        public static string iStock_nBox_432R = "iStock.nBox.432R";
        public static string iStock_nBox_433F = "iStock.nBox.433F";
        public static string iStock_nBox_433R = "iStock.nBox.433R";
        public static string iStock_nBox_441F = "iStock.nBox.441F";
        public static string iStock_nBox_441R = "iStock.nBox.441R";
        public static string iStock_nBox_442F = "iStock.nBox.442F";
        public static string iStock_nBox_442R = "iStock.nBox.442R";
        public static string iStock_nBox_443F = "iStock.nBox.443F";
        public static string iStock_nBox_443R = "iStock.nBox.443R";
        public static string iStock_nBox_451F = "iStock.nBox.451F";
        public static string iStock_nBox_451R = "iStock.nBox.451R";
        public static string iStock_nBox_452F = "iStock.nBox.452F";
        public static string iStock_nBox_452R = "iStock.nBox.452R";
        public static string iStock_nBox_453F = "iStock.nBox.453F";
        public static string iStock_nBox_453R = "iStock.nBox.453R";
        public static string iStock_nBox_511F = "iStock.nBox.511F";
        public static string iStock_nBox_511R = "iStock.nBox.511R";
        public static string iStock_nBox_512F = "iStock.nBox.512F";
        public static string iStock_nBox_512R = "iStock.nBox.512R";
        public static string iStock_nBox_513F = "iStock.nBox.513F";
        public static string iStock_nBox_513R = "iStock.nBox.513R";
        public static string iStock_nBox_521F = "iStock.nBox.521F";
        public static string iStock_nBox_521R = "iStock.nBox.521R";
        public static string iStock_nBox_522F = "iStock.nBox.522F";
        public static string iStock_nBox_522R = "iStock.nBox.522R";
        public static string iStock_nBox_523F = "iStock.nBox.523F";
        public static string iStock_nBox_523R = "iStock.nBox.523R";
        public static string iStock_nBox_531F = "iStock.nBox.531F";
        public static string iStock_nBox_531R = "iStock.nBox.531R";
        public static string iStock_nBox_532F = "iStock.nBox.532F";
        public static string iStock_nBox_532R = "iStock.nBox.532R";
        public static string iStock_nBox_533F = "iStock.nBox.533F";
        public static string iStock_nBox_533R = "iStock.nBox.533R";
        public static string iStock_nBox_541F = "iStock.nBox.541F";
        public static string iStock_nBox_541R = "iStock.nBox.541R";
        public static string iStock_nBox_542F = "iStock.nBox.542F";
        public static string iStock_nBox_542R = "iStock.nBox.542R";
        public static string iStock_nBox_543F = "iStock.nBox.543F";
        public static string iStock_nBox_543R = "iStock.nBox.543R";
        public static string iStock_nBox_551F = "iStock.nBox.551F";
        public static string iStock_nBox_551R = "iStock.nBox.551R";
        public static string iStock_nBox_552F = "iStock.nBox.552F";
        public static string iStock_nBox_552R = "iStock.nBox.552R";
        public static string iStock_nBox_553F = "iStock.nBox.553F";
        public static string iStock_nBox_553R = "iStock.nBox.553R";
        public static string iStock_nBox_611F = "iStock.nBox.611F";
        public static string iStock_nBox_611R = "iStock.nBox.611R";
        public static string iStock_nBox_612F = "iStock.nBox.612F";
        public static string iStock_nBox_612R = "iStock.nBox.612R";
        public static string iStock_nBox_613F = "iStock.nBox.613F";
        public static string iStock_nBox_613R = "iStock.nBox.613R";
        public static string iStock_nBox_621F = "iStock.nBox.621F";
        public static string iStock_nBox_621R = "iStock.nBox.621R";
        public static string iStock_nBox_622F = "iStock.nBox.622F";
        public static string iStock_nBox_622R = "iStock.nBox.622R";
        public static string iStock_nBox_623F = "iStock.nBox.623F";
        public static string iStock_nBox_623R = "iStock.nBox.623R";
        public static string iStock_nBox_631F = "iStock.nBox.631F";
        public static string iStock_nBox_631R = "iStock.nBox.631R";
        public static string iStock_nBox_632F = "iStock.nBox.632F";
        public static string iStock_nBox_632R = "iStock.nBox.632R";
        public static string iStock_nBox_633F = "iStock.nBox.633F";
        public static string iStock_nBox_633R = "iStock.nBox.633R";
        public static string iStock_nBox_641F = "iStock.nBox.641F";
        public static string iStock_nBox_641R = "iStock.nBox.641R";
        public static string iStock_nBox_642F = "iStock.nBox.642F";
        public static string iStock_nBox_642R = "iStock.nBox.642R";
        public static string iStock_nBox_643F = "iStock.nBox.643F";
        public static string iStock_nBox_643R = "iStock.nBox.643R";
        public static string iStock_nBox_651F = "iStock.nBox.651F";
        public static string iStock_nBox_651R = "iStock.nBox.651R";
        public static string iStock_nBox_652F = "iStock.nBox.652F";
        public static string iStock_nBox_652R = "iStock.nBox.652R";
        public static string iStock_nBox_653F = "iStock.nBox.653F";
        public static string iStock_nBox_653R = "iStock.nBox.653R";
        public static string iStock_nBox_711F = "iStock.nBox.711F";
        public static string iStock_nBox_711R = "iStock.nBox.711R";
        public static string iStock_nBox_712F = "iStock.nBox.712F";
        public static string iStock_nBox_712R = "iStock.nBox.712R";
        public static string iStock_nBox_713F = "iStock.nBox.713F";
        public static string iStock_nBox_713R = "iStock.nBox.713R";
        public static string iStock_nBox_721F = "iStock.nBox.721F";
        public static string iStock_nBox_721R = "iStock.nBox.721R";
        public static string iStock_nBox_722F = "iStock.nBox.722F";
        public static string iStock_nBox_722R = "iStock.nBox.722R";
        public static string iStock_nBox_723F = "iStock.nBox.723F";
        public static string iStock_nBox_723R = "iStock.nBox.723R";
        public static string iStock_nBox_731F = "iStock.nBox.731F";
        public static string iStock_nBox_731R = "iStock.nBox.731R";
        public static string iStock_nBox_732F = "iStock.nBox.732F";
        public static string iStock_nBox_732R = "iStock.nBox.732R";
        public static string iStock_nBox_733F = "iStock.nBox.733F";
        public static string iStock_nBox_733R = "iStock.nBox.733R";
        public static string iStock_nBox_741F = "iStock.nBox.741F";
        public static string iStock_nBox_741R = "iStock.nBox.741R";
        public static string iStock_nBox_742F = "iStock.nBox.742F";
        public static string iStock_nBox_742R = "iStock.nBox.742R";
        public static string iStock_nBox_743F = "iStock.nBox.743F";
        public static string iStock_nBox_743R = "iStock.nBox.743R";
        public static string iStock_nBox_751F = "iStock.nBox.751F";
        public static string iStock_nBox_751R = "iStock.nBox.751R";
        public static string iStock_nBox_752F = "iStock.nBox.752F";
        public static string iStock_nBox_752R = "iStock.nBox.752R";
        public static string iStock_nBox_753F = "iStock.nBox.753F";
        public static string iStock_nBox_753R = "iStock.nBox.753R";
        public static string iStock_nBox_811F = "iStock.nBox.811F";
        public static string iStock_nBox_811R = "iStock.nBox.811R";
        public static string iStock_nBox_812F = "iStock.nBox.812F";
        public static string iStock_nBox_812R = "iStock.nBox.812R";
        public static string iStock_nBox_813F = "iStock.nBox.813F";
        public static string iStock_nBox_813R = "iStock.nBox.813R";
        public static string iStock_nBox_821F = "iStock.nBox.821F";
        public static string iStock_nBox_821R = "iStock.nBox.821R";
        public static string iStock_nBox_822F = "iStock.nBox.822F";
        public static string iStock_nBox_822R = "iStock.nBox.822R";
        public static string iStock_nBox_823F = "iStock.nBox.823F";
        public static string iStock_nBox_823R = "iStock.nBox.823R";
        public static string iStock_nBox_831F = "iStock.nBox.831F";
        public static string iStock_nBox_831R = "iStock.nBox.831R";
        public static string iStock_nBox_832F = "iStock.nBox.832F";
        public static string iStock_nBox_832R = "iStock.nBox.832R";
        public static string iStock_nBox_833F = "iStock.nBox.833F";
        public static string iStock_nBox_833R = "iStock.nBox.833R";
        public static string iStock_nBox_841F = "iStock.nBox.841F";
        public static string iStock_nBox_841R = "iStock.nBox.841R";
        public static string iStock_nBox_842F = "iStock.nBox.842F";
        public static string iStock_nBox_842R = "iStock.nBox.842R";
        public static string iStock_nBox_843F = "iStock.nBox.843F";
        public static string iStock_nBox_843R = "iStock.nBox.843R";
        public static string iStock_nBox_851F = "iStock.nBox.851F";
        public static string iStock_nBox_851R = "iStock.nBox.851R";
        public static string iStock_nBox_852F = "iStock.nBox.852F";
        public static string iStock_nBox_852R = "iStock.nBox.852R";
        public static string iStock_nBox_853F = "iStock.nBox.853F";
        public static string iStock_nBox_853R = "iStock.nBox.853R";



        public static string iXAxis_dAct_Pos = "iXAxis.dAct.Pos";
        public static string iXAxis_dAct_Velo = "iXAxis.dAct.Velo";
        public static string iXAxis_dSet_Pos = "iXAxis.dSet.Pos";
        public static string iXAxis_dSet_Velo = "iXAxis.dSet.Velo";
        public static string iXAxis_dCtrl_Override = "iXAxis.dCtrl.Override";
        public static string iXAxis_nStatus_ErrId = "iXAxis.nStatus.ErrId";
        public static string iXAxis_nStatus_HasErr = "iXAxis.nStatus.HasErr";
        public static string iXAxis_nStatus_IsReady = "iXAxis.nStatus.IsReady";
        public static string iXAxis_nStatus_IsDisabled = "iXAxis.nStatus.IsDisabled";
        public static string iXAxis_nStatus_IsFwDisabled = "iXAxis.nStatus.IsFwDisabled";
        public static string iXAxis_nStatus_IsBwDisabled = "iXAxis.nStatus.IsBwDisabled";
        public static string iXAxis_nStatus_IsCalibrated = "iXAxis.nStatus.IsCalibrated";
        public static string iXAxis_nStatus_HasJob = "iXAxis.nStatus.HasJob";
        public static string iXAxis_nStatus_IsNotMove = "iXAxis.nStatus.IsNotMove";
        public static string iXAxis_nDir_IsPositive = "iXAxis.nDir.IsPositive";
        public static string iXAxis_nDir_IsNegative = "iXAxis.nDir.IsNegative";
        public static string iXAxis_nTarget_IsIn = "iXAxis.nTarget.IsIn";
        public static string iXAxis_nRange_IsIn = "iXAxis.nRange.IsIn";
        public static string iYAxis_dAct_Pos = "iYAxis.dAct.Pos";
        public static string iYAxis_dAct_Velo = "iYAxis.dAct.Velo";
        public static string iYAxis_dSet_Pos = "iYAxis.dSet.Pos";
        public static string iYAxis_dSet_Velo = "iYAxis.dSet.Velo";
        public static string iYAxis_dCtrl_Override = "iYAxis.dCtrl.Override";
        public static string iYAxis_nStatus_ErrId = "iYAxis.nStatus.ErrId";
        public static string iYAxis_nStatus_HasErr = "iYAxis.nStatus.HasErr";
        public static string iYAxis_nStatus_IsReady = "iYAxis.nStatus.IsReady";
        public static string iYAxis_nStatus_IsDisabled = "iYAxis.nStatus.IsDisabled";
        public static string iYAxis_nStatus_IsFwDisabled = "iYAxis.nStatus.IsFwDisabled";
        public static string iYAxis_nStatus_IsBwDisabled = "iYAxis.nStatus.IsBwDisabled";
        public static string iYAxis_nStatus_IsCalibrated = "iYAxis.nStatus.IsCalibrated";
        public static string iYAxis_nStatus_HasJob = "iYAxis.nStatus.HasJob";
        public static string iYAxis_nStatus_IsNotMove = "iYAxis.nStatus.IsNotMove";
        public static string iYAxis_nDir_IsPositive = "iYAxis.nDir.IsPositive";
        public static string iYAxis_nDir_IsNegative = "iYAxis.nDir.IsNegative";
        public static string iYAxis_nTarget_IsIn = "iYAxis.nTarget.IsIn";
        public static string iYAxis_nRange_IsIn = "iYAxis.nRange.IsIn";
        public static string iZAxis_dAct_Pos = "iZAxis.dAct.Pos";
        public static string iZAxis_dAct_Velo = "iZAxis.dAct.Velo";
        public static string iZAxis_dSet_Pos = "iZAxis.dSet.Pos";
        public static string iZAxis_dSet_Velo = "iZAxis.dSet.Velo";
        public static string iZAxis_dCtrl_Override = "iZAxis.dCtrl.Override";
        public static string iZAxis_nStatus_ErrId = "iZAxis.nStatus.ErrId";
        public static string iZAxis_nStatus_HasErr = "iZAxis.nStatus.HasErr";
        public static string iZAxis_nStatus_IsReady = "iZAxis.nStatus.IsReady";
        public static string iZAxis_nStatus_IsDisabled = "iZAxis.nStatus.IsDisabled";
        public static string iZAxis_nStatus_IsFwDisabled = "iZAxis.nStatus.IsFwDisabled";
        public static string iZAxis_nStatus_IsBwDisabled = "iZAxis.nStatus.IsBwDisabled";
        public static string iZAxis_nStatus_IsCalibrated = "iZAxis.nStatus.IsCalibrated";
        public static string iZAxis_nStatus_HasJob = "iZAxis.nStatus.HasJob";
        public static string iZAxis_nStatus_IsNotMove = "iZAxis.nStatus.IsNotMove";
        public static string iZAxis_nDir_IsPositive = "iZAxis.nDir.IsPositive";
        public static string iZAxis_nDir_IsNegative = "iZAxis.nDir.IsNegative";
        public static string iZAxis_nTarget_IsIn = "iZAxis.nTarget.IsIn";
        public static string iZAxis_nRange_IsIn = "iZAxis.nRange.IsIn";
        public static string iTAxis_dAct_Pos = "iTAxis.dAct.Pos";
        public static string iTAxis_dAct_Velo = "iTAxis.dAct.Velo";
        public static string iTAxis_dSet_Pos = "iTAxis.dSet.Pos";
        public static string iTAxis_dSet_Velo = "iTAxis.dSet.Velo";
        public static string iTAxis_dCtrl_Override = "iTAxis.dCtrl.Override";
        public static string iTAxis_nStatus_ErrId = "iTAxis.nStatus.ErrId";
        public static string iTAxis_nStatus_HasErr = "iTAxis.nStatus.HasErr";
        public static string iTAxis_nStatus_IsReady = "iTAxis.nStatus.IsReady";
        public static string iTAxis_nStatus_IsDisabled = "iTAxis.nStatus.IsDisabled";
        public static string iTAxis_nStatus_IsFwDisabled = "iTAxis.nStatus.IsFwDisabled";
        public static string iTAxis_nStatus_IsBwDisabled = "iTAxis.nStatus.IsBwDisabled";
        public static string iTAxis_nStatus_IsCalibrated = "iTAxis.nStatus.IsCalibrated";
        public static string iTAxis_nStatus_HasJob = "iTAxis.nStatus.HasJob";
        public static string iTAxis_nStatus_IsNotMove = "iTAxis.nStatus.IsNotMove";
        public static string iTAxis_nDir_IsPositive = "iTAxis.nDir.IsPositive";
        public static string iTAxis_nDir_IsNegative = "iTAxis.nDir.IsNegative";
        public static string iTAxis_nTarget_IsIn = "iTAxis.nTarget.IsIn";
        public static string iTAxis_nRange_IsIn = "iTAxis.nRange.IsIn";

        public static string oXAxis_dTarget_Pos = "oXAxis.dTarget.Pos";
        public static string oXAxis_dTarget_Velo = "oXAxis.dTarget.Velo";
        public static string oXAxis_dTarget_Acc = "oXAxis.dTarget.Acc";
        public static string oXAxis_dTarget_Dcc = "oXAxis.dTarget.Dcc";
        public static string oXAxis_dTarget_Jerk = "oXAxis.dTarget.Jerk";
        public static string oXAxis_dCtrl_Override = "oXAxis.dCtrl.Override";
        public static string oXAxis_nServo_On = "oXAxis.nServo.On";
        public static string oXAxis_nServo_FwOn = "oXAxis.nServo.FwOn";
        public static string oXAxis_nServo_BwOn = "oXAxis.nServo.BwOn";
        public static string oXAxis_nServo_Off = "oXAxis.nServo.Off";
        public static string oXAxis_nServo_MoveABS = "oXAxis.nServo.MoveABS";
        public static string oXAxis_nServo_MoveREL = "oXAxis.nServo.MoveREL";
        public static string oXAxis_nServo_Halt = "oXAxis.nServo.Halt";
        public static string oXAxis_nServo_Home = "oXAxis.nServo.Home";
        public static string oXAxis_nServo_Reset = "oXAxis.nServo.Reset";
        public static string oXAxis_nJog_Mode = "oXAxis.nJog.Mode";
        public static string oXAxis_nJog_FwFast = "oXAxis.nJog.FwFast";
        public static string oXAxis_nJog_BwFast = "oXAxis.nJog.BwFast";
        public static string oXAxis_nJog_FwSlow = "oXAxis.nJog.FwSlow";
        public static string oXAxis_nJog_BwSlow = "oXAxis.nJog.BwSlow";
        public static string oYAxis_dTarget_Pos = "oYAxis.dTarget.Pos";
        public static string oYAxis_dTarget_Velo = "oYAxis.dTarget.Velo";
        public static string oYAxis_dTarget_Acc = "oYAxis.dTarget.Acc";
        public static string oYAxis_dTarget_Dcc = "oYAxis.dTarget.Dcc";
        public static string oYAxis_dTarget_Jerk = "oYAxis.dTarget.Jerk";
        public static string oYAxis_dCtrl_Override = "oYAxis.dCtrl.Override";
        public static string oYAxis_nServo_On = "oYAxis.nServo.On";
        public static string oYAxis_nServo_FwOn = "oYAxis.nServo.FwOn";
        public static string oYAxis_nServo_BwOn = "oYAxis.nServo.BwOn";
        public static string oYAxis_nServo_Off = "oYAxis.nServo.Off";
        public static string oYAxis_nServo_MoveABS = "oYAxis.nServo.MoveABS";
        public static string oYAxis_nServo_MoveREL = "oYAxis.nServo.MoveREL";
        public static string oYAxis_nServo_Halt = "oYAxis.nServo.Halt";
        public static string oYAxis_nServo_Home = "oYAxis.nServo.Home";
        public static string oYAxis_nServo_Reset = "oYAxis.nServo.Reset";
        public static string oYAxis_nJog_Mode = "oYAxis.nJog.Mode";
        public static string oYAxis_nJog_FwFast = "oYAxis.nJog.FwFast";
        public static string oYAxis_nJog_BwFast = "oYAxis.nJog.BwFast";
        public static string oYAxis_nJog_FwSlow = "oYAxis.nJog.FwSlow";
        public static string oYAxis_nJog_BwSlow = "oYAxis.nJog.BwSlow";
        public static string oZAxis_dTarget_Pos = "oZAxis.dTarget.Pos";
        public static string oZAxis_dTarget_Velo = "oZAxis.dTarget.Velo";
        public static string oZAxis_dTarget_Acc = "oZAxis.dTarget.Acc";
        public static string oZAxis_dTarget_Dcc = "oZAxis.dTarget.Dcc";
        public static string oZAxis_dTarget_Jerk = "oZAxis.dTarget.Jerk";
        public static string oZAxis_dCtrl_Override = "oZAxis.dCtrl.Override";
        public static string oZAxis_nServo_On = "oZAxis.nServo.On";
        public static string oZAxis_nServo_FwOn = "oZAxis.nServo.FwOn";
        public static string oZAxis_nServo_BwOn = "oZAxis.nServo.BwOn";
        public static string oZAxis_nServo_Off = "oZAxis.nServo.Off";
        public static string oZAxis_nServo_MoveABS = "oZAxis.nServo.MoveABS";
        public static string oZAxis_nServo_MoveREL = "oZAxis.nServo.MoveREL";
        public static string oZAxis_nServo_Halt = "oZAxis.nServo.Halt";
        public static string oZAxis_nServo_Home = "oZAxis.nServo.Home";
        public static string oZAxis_nServo_Reset = "oZAxis.nServo.Reset";
        public static string oZAxis_nJog_Mode = "oZAxis.nJog.Mode";
        public static string oZAxis_nJog_FwFast = "oZAxis.nJog.FwFast";
        public static string oZAxis_nJog_BwFast = "oZAxis.nJog.BwFast";
        public static string oZAxis_nJog_FwSlow = "oZAxis.nJog.FwSlow";
        public static string oZAxis_nJog_BwSlow = "oZAxis.nJog.BwSlow";
        public static string oTAxis_dTarget_Pos = "oTAxis.dTarget.Pos";
        public static string oTAxis_dTarget_Velo = "oTAxis.dTarget.Velo";
        public static string oTAxis_dTarget_Acc = "oTAxis.dTarget.Acc";
        public static string oTAxis_dTarget_Dcc = "oTAxis.dTarget.Dcc";
        public static string oTAxis_dTarget_Jerk = "oTAxis.dTarget.Jerk";
        public static string oTAxis_dCtrl_Override = "oTAxis.dCtrl.Override";
        public static string oTAxis_nServo_On = "oTAxis.nServo.On";
        public static string oTAxis_nServo_FwOn = "oTAxis.nServo.FwOn";
        public static string oTAxis_nServo_BwOn = "oTAxis.nServo.BwOn";
        public static string oTAxis_nServo_Off = "oTAxis.nServo.Off";
        public static string oTAxis_nServo_MoveABS = "oTAxis.nServo.MoveABS";
        public static string oTAxis_nServo_MoveREL = "oTAxis.nServo.MoveREL";
        public static string oTAxis_nServo_Halt = "oTAxis.nServo.Halt";
        public static string oTAxis_nServo_Home = "oTAxis.nServo.Home";
        public static string oTAxis_nServo_Reset = "oTAxis.nServo.Reset";
        public static string oTAxis_nJog_Mode = "oTAxis.nJog.Mode";
        public static string oTAxis_nJog_FwFast = "oTAxis.nJog.FwFast";
        public static string oTAxis_nJog_BwFast = "oTAxis.nJog.BwFast";
        public static string oTAxis_nJog_FwSlow = "oTAxis.nJog.FwSlow";
        public static string oTAxis_nJog_BwSlow = "oTAxis.nJog.BwSlow";

    }
}
