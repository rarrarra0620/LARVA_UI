using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device.Beckhoff
{
    #region Function results

    enum epInOut
    {
        P_OUT = 0,
        P_IN = 1,
        ALARM = 2,
        M_IN = 3,
        M_OUT = 4,
        T_OUT = 5,
        T_IN = 6,
    }

    enum tcAxisFeedbackParam
    {
        ActPos = 0, 
        ActVel = 1,
        SetPos = 2,
        SetVel = 3,
        ControlOverride = 4,
        ErrorId = 5,
        HasError = 6,
        IsReady = 7,
        IsDisabled = 8,
        IsFwDisabled = 9,
        IsBwDisabled = 10,
        IsCalibrated = 11,
        HasJob = 12,
        IsNotMove = 13,
        IsPositive = 14,
        IsNegative = 15,
        IsInTarget = 16,
        IsInRange = 17,
    }

    enum tcAxisControlParam
    {
        TargetPos = 0,
        TargetVel = 1,
        TargetAcc = 2,
        TargetDcc = 3,
        TargetJerk = 4,
        ControlOverride = 5,
        ServoEnable = 6,
        ServoFwOn = 7,
        ServoBwOn = 8,
        ServoDisable = 9,
        ServoMoveAbs = 10,
        ServoMoveRel = 11,
        ServoHalt = 12,
        ServoHome = 13,
        ServoReset = 14,
        JogMode     = 15,
        JogFwFast = 16,
        JogBwFast = 17,
        JogFwSlow = 18,
        JogBwSlow = 19
    }

    enum tcFunctionResult
    {
        TC_SUCCESS = 0,
        TC_PARTIAL_FAILURE,
        TC_NOT_CONNECTED,
        TC_GENERAL_FAILURE_1,
        TC_FAIL_TO_LOAD_PLC_CONFIG,
        TC_FAIL_TO_CREATE_HANDLE,
        TC_FAIL_TO_READ_DATA,
        TC_FAIL_TO_WRITE_DATA,
        TC_FAIL_TO_CONNECT_DEVICE,
        TC_VARLIST_OUTOFBOUND,
        TC_AXIS_OUTOFBOUND,
        TC_FAIL_TO_READ_AXIS_FEEDBACK,
        TC_NO_AXIS
    }
    #endregion

    #region Data Type
    enum tcDataType
    {
        BOOL = 0,
        BYTE = 1,
        INT16 = 2,
        INT32 = 3,
        REAL = 4,
        LREAL = 5,
        STRING_32 = 9,
        
    }

    enum tcAxis
    {
        X_AXIS = 0,
        Y_AXIS = 1,
        Z_AXIS = 2,
        R_AXIS = 3
    }

    enum tcKind
    {
        DI = 0,
        DO = 1,
        AI = 2,
        AO = 3
    }
    #endregion

    #region Data Structure
    struct tcPlcVar
    {
        public string Name;
        public string Type;
        public int Size;
        public int Count;
        public object Data;
        public int Handle;
        public string Tag;
        public int Index;
    }

    struct tcDataVar
    {
        public tcKind Kind;
        public string Name;
        public int Index;
        public int Offset;
    }

    public class Axis_PlcToHmi
    {
        public bool isReady = false;
        public bool isDisabled = false;
        public bool isFwDisabled = false;
        public bool isBwDisabled = false;
        public bool isCalibrated = false;
        public bool hasJob = false;
        public bool isNotMoving = false;
        public bool isPositiveDirection = false;
        public bool isNegativeDirection = false;
        public bool isInTarget = false;
        public bool isInRange = false;
        public bool hasError = false;
        public uint ErrorID = 0;
        public double controlleroverride = 0;
        public double actualPosition = 0, actualVelocity = 0;
        public double setPosition = 0, setVelocity = 0;
    }
    public class Axis_HmiToPlc
    {
        public double TARGET_POSITION { get; set; }
        public double TARGET_VELOCITY { get; set; }
        public double TARGET_ACCELERATION { get; set; }
        public double TARGET_DECELERATION { get; set; }
        public double TARGET_JERK { get; set; }
        public double CONTROLLER_OVERRIDE { get; set; }
        public bool SERVO_HALT { get; set; }
        public bool SERVO_ON { get; set; }
        public bool SERVO_ON_FW { get; set; }
        public bool SERVO_ON_BW { get; set; }
        public bool SERVO_OFF { get; set; }
        public bool SERVO_MOVE_ABS { get; set; }
        public bool SERVO_MOVE_REL { get; set; }
        public bool SERVO_HOME { get; set; }
        public bool SERVO_RESET { get; set; }
        public bool SERVO_JOG_MODE { get; set; }
        public bool SERVO_JOG_FW_FAST { get; set; }
        public bool SERVO_JOG_BW_FAST { get; set; }
        public bool SERVO_JOG_FW_SLOW { get; set; }
        public bool SERVO_JOG_BW_SLOW { get; set; }
    }
    #endregion


    #region Special Definitions
    public class _Axis_PlcToHmi
    {
        public int handle = 0;
        public short size = 0;
        public bool isReady = false;
        public bool isDisabled = false;
        public bool isFwDisabled = false;
        public bool isBwDisabled = false;
        public bool isCalibrated = false;
        public bool hasJob = false;
        public bool isNotMoving = false;
        public bool isPositiveDirection = false;
        public bool isNegativeDirection = false;
        public bool isInTarget = false;
        public bool isInRange = false;
        public bool hasError = false;
        public uint ErrorId = 0;
        public double controlleroverride = 0;
        public double actualPosition = 0, actualVelocity = 0;
        public double setPosition = 0, setVelocity = 0;
    }
    public class _Axis_HmiToPlc
    {
        public int handle = 0;
        public short size = 0;
        public double TARGET_POSITION { get; set; }
        public double TARGET_VELOCITY { get; set; }
        public double TARGET_ACCELERATION { get; set; }
        public double TARGET_DECELERATION { get; set; }
        public double TARGET_JERK { get; set; }
        public double CONTROLLER_OVERRIDE { get; set; }
        public bool SERVO_HALT { get; set; }
        public bool SERVO_ON { get; set; }
        public bool SERVO_ON_FW { get; set; }
        public bool SERVO_ON_BW { get; set; }
        public bool SERVO_OFF { get; set; }
        public bool SERVO_MOVE_ABS { get; set; }
        public bool SERVO_MOVE_REL { get; set; }
        public bool SERVO_HOME { get; set; }
        public bool SERVO_RESET { get; set; }
        public bool SERVO_JOG_MODE { get; set; }
        public bool SERVO_JOG_FW_FAST { get; set; }
        public bool SERVO_JOG_BW_FAST { get; set; }
        public bool SERVO_JOG_FW_SLOW { get; set; }
        public bool SERVO_JOG_BW_SLOW { get; set; }
    }
    #endregion
}
