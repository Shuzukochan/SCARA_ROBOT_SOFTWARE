using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCARA_ROBOT_SOFTWARE
{
    public static class GlobalVariables
    {
        public static bool[] ButtonStates_1 = new bool[96];
        public static bool[] ButtonStates_2 = new bool[96];
        public static bool[] ButtonStates_3 = new bool[96];
        public static bool[] ButtonStates_4 = new bool[96];
        public static bool[] ButtonStates_5 = new bool[96];
        public static bool[] ButtonStates_6 = new bool[96];
        public static bool[] ButtonStates_7 = new bool[96];
        public static bool[] ButtonStates_8 = new bool[96];
        public static bool[] ButtonStates_9 = new bool[96];
        public static bool[] ButtonStates_10 = new bool[96];

        public static bool[] _ButtonStates_1 = new bool[96];
        public static bool[] _ButtonStates_2 = new bool[96];
        public static bool[] _ButtonStates_3 = new bool[96];
        public static bool[] _ButtonStates_4 = new bool[96];
        public static bool[] _ButtonStates_5 = new bool[96];
        public static bool[] _ButtonStates_6 = new bool[96];
        public static bool[] _ButtonStates_7 = new bool[96];
        public static bool[] _ButtonStates_8 = new bool[96];
        public static bool[] _ButtonStates_9 = new bool[96];
        public static bool[] _ButtonStates_10 = new bool[96];

        public static bool[] TempButtonStates = new bool[96];
        public static int[] TempButtonStates_1 = new int[96];
        public static int[] TempButtonStates_2 = new int[96];
        public static int[] TempButtonStates_11 = new int[96];
        public static int[] TempButtonStates_12 = new int[96];

        public static string ProgramName = "";
        public static string ProgramName_1 = "";
        public static string _ProgramName_2 = "";
        public static string ProgramName1 = "";
        public static string ProgramName1_1 = "";

        public static string? selectedPort = "";
        public static int selectedBaudrate = 0;

        public static byte SelectProgram;
        public static byte SetupProgram;
        public static int Distribution;
        public static int Distribution_1;
        public static int Distribution_2;

        public static bool AreaState = false;
        public static bool Calibration = false;
        public static bool _resetHomeState = true;
        public static bool _runned = false;
        public static bool isSelect = false;

        public static string Program1_Name = "";
        public static string Program2_Name = "";
        public static string Program3_Name = "";
        public static string Program4_Name = "";
        public static string Program5_Name = "";
        public static string Program6_Name = "";
        public static string Program7_Name = "";
        public static string Program8_Name = "";
        public static string Program9_Name = "";
        public static string Program10_Name = "";

        private static string _programName2 = "";
        private static string _quanity = "";
        private static string _volume = "";
        private static string _pumpSpeed = "";
        private static string _tubeID = "";
        private static string _speedXY = "";
        private static string _antidrop = "";

        private static string _programName22 = "";
        private static string _quanity2 = "";
        private static string _volume2 = "";
        private static string _pumpSpeed2 = "";
        private static string _tubeID2 = "";
        private static string _speedXY2 = "";
        private static string _antidrop2 = "";

        private static string _programName23 = "";
        private static string _parametersName = "";
        private static string _parameters = "";
        private static string _coordinates1 = "";
        private static string _coordinates2 = "";

        private static string _step = "";
        private static string _feed = "";
        private static string _xCoordinate = "";
        private static string _yCoordinate = "";
        private static string _zCoordinate = "";
        private static string _saveState = "";

        private static string _programName24 = "";
        private static string _totalFillTube = "";
        private static string _pumpControl = "";
        private static string _xCoordinate1 = "";
        private static string _yCoordinate1 = "";
        private static string _zCoordinate1 = "";

        private static string _passwordWarning = "";

        private static string _tubePerColumn = "";
        private static string _tubePerRow = "";
        private static string _speedXYAxis = "";

        private static string _volumeSetup = "";
        private static string _tubingIDSetup = "";
        private static string _pumpSpeedSetup = "";
        private static string _antiDropSetup = "";

        private static string _parameters1 = "";
        private static string _parameters2 = "";
        private static string _programName25 = "";
        private static string _programName26 = "";
        private static string _quanity3 = "";
        private static string _volume3 = "";
        private static string _pumpSpeed3 = "";
        private static string _tubeID3 = "";
        private static string _speedXY3 = "";
        private static string _antidrop3 = "";

        private static string _quanity4 = "";
        private static string _volume4 = "";
        private static string _pumpSpeed4 = "";
        private static string _tubeID4 = "";
        private static string _speedXY4 = "";
        private static string _antidrop4 = "";

        private static string _fillNumber = "";
        private static string _actualWeight = "";
        private static string _density = "";

        private static string _fillNumberInformation = "";
        private static string _timeRunInformation = "";
        private static string _timeDelayInformation = "";
        private static string _cyclesInformation = "";

        private static string _hourInformation = "";
        private static string _minutesInformation = "";
        private static string _secondInformation = "";

        public static bool areaChanged = false;
        public static bool areaChanged_1 = false;
        public static bool flagArea = true;

        public static int Cycle;

        public static event Action? VariablesChanged;

        public static string ProgramName_2
        {
            get => _programName2;
            set { if (_programName2 != value) { _programName2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Quanity
        {
            get => _quanity;
            set { if (_quanity != value) { _quanity = value; VariablesChanged?.Invoke(); } }
        }

        public static string Volume
        {
            get => _volume;
            set { if (_volume != value) { _volume = value; VariablesChanged?.Invoke(); } }
        }

        public static string PumpSpeed
        {
            get => _pumpSpeed;
            set { if (_pumpSpeed != value) { _pumpSpeed = value; VariablesChanged?.Invoke(); } }
        }

        public static string TubeID
        {
            get => _tubeID;
            set { if (_tubeID != value) { _tubeID = value; VariablesChanged?.Invoke(); } }
        }

        public static string SpeedXY
        {
            get => _speedXY;
            set { if (_speedXY != value) { _speedXY = value; VariablesChanged?.Invoke(); } }
        }

        public static string Antidrop
        {
            get => _antidrop;
            set { if (_antidrop != value) { _antidrop = value; VariablesChanged?.Invoke(); } }
        }

        public static string ProgramName_22
        {
            get => _programName22;
            set { if (_programName22 != value) { _programName22 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Quanity2
        {
            get => _quanity2;
            set { if (_quanity2 != value) { _quanity2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Volume2
        {
            get => _volume2;
            set { if (_volume2 != value) { _volume2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string PumpSpeed2
        {
            get => _pumpSpeed2;
            set { if (_pumpSpeed2 != value) { _pumpSpeed2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string TubeID2
        {
            get => _tubeID2;
            set { if (_tubeID2 != value) { _tubeID2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string SpeedXY2
        {
            get => _speedXY2;
            set { if (_speedXY2 != value) { _speedXY2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Antidrop2
        {
            get => _antidrop2;
            set { if (_antidrop2 != value) { _antidrop2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string ProgramName_23
        {
            get => _programName23;
            set { if (_programName23 != value) { _programName23 = value; VariablesChanged?.Invoke(); } }
        }

        public static string ParametersName
        {
            get => _parametersName;
            set { if (_parametersName != value) { _parametersName = value; VariablesChanged?.Invoke(); } }
        }

        public static string Parameters
        {
            get => _parameters;
            set { if (_parameters != value) { _parameters = value; VariablesChanged?.Invoke(); } }
        }

        public static string Coordinates1
        {
            get => _coordinates1;
            set { if (_coordinates1 != value) { _coordinates1 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Coordinates2
        {
            get => _coordinates2;
            set { if (_coordinates2 != value) { _coordinates2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Step
        {
            get => _step;
            set { if (_step != value) { _step = value; VariablesChanged?.Invoke(); } }
        }

        public static string Feed
        {
            get => _feed;
            set { if (_feed != value) { _feed = value; VariablesChanged?.Invoke(); } }
        }

        public static string xCoordinate
        {
            get => _xCoordinate;
            set { if (_xCoordinate != value) { _xCoordinate = value; VariablesChanged?.Invoke(); } }
        }

        public static string yCoordinate
        {
            get => _yCoordinate;
            set { if (_yCoordinate != value) { _yCoordinate = value; VariablesChanged?.Invoke(); } }
        }

        public static string zCoordinate
        {
            get => _zCoordinate;
            set { if (_zCoordinate != value) { _zCoordinate = value; VariablesChanged?.Invoke(); } }
        }

        public static string SaveState
        {
            get => _saveState;
            set { if (_saveState != value) { _saveState = value; VariablesChanged?.Invoke(); } }
        }

        public static string ProgramName_24
        {
            get => _programName24;
            set { if (_programName24 != value) { _programName24 = value; VariablesChanged?.Invoke(); } }
        }

        public static string xCoordinate1
        {
            get => _xCoordinate1;
            set { if (_xCoordinate1 != value) { _xCoordinate1 = value; VariablesChanged?.Invoke(); } }
        }

        public static string yCoordinate1
        {
            get => _yCoordinate1;
            set { if (_yCoordinate1 != value) { _yCoordinate1 = value; VariablesChanged?.Invoke(); } }
        }

        public static string zCoordinate1
        {
            get => _zCoordinate1;
            set { if (_zCoordinate1 != value) { _zCoordinate1 = value; VariablesChanged?.Invoke(); } }
        }

        public static string TotalFillTube
        {
            get => _totalFillTube;
            set { if (_totalFillTube != value) { _totalFillTube = value; VariablesChanged?.Invoke(); } }
        }
        public static string PumpControl
        {
            get => _pumpControl;
            set { if (_pumpControl != value) { _pumpControl = value; VariablesChanged?.Invoke(); } }
        }

        public static string PasswordWarning
        {
            get => _passwordWarning;
            set { if (_passwordWarning != value) { _passwordWarning = value; VariablesChanged?.Invoke(); } }
        }
        public static string TubePerColumn
        {
            get => _tubePerColumn;
            set { if (_tubePerColumn != value) { _tubePerColumn = value; VariablesChanged?.Invoke(); } }
        }
        public static string TubePerRow
        {
            get => _tubePerRow;
            set { if (_tubePerRow != value) { _tubePerRow = value; VariablesChanged?.Invoke(); } }
        }
        public static string SpeedXYAxis
        {
            get => _speedXYAxis;
            set { if (_speedXYAxis != value) { _speedXYAxis = value; VariablesChanged?.Invoke(); } }
        }
        public static string VolumeSetup
        {
            get => _volumeSetup;
            set { if (_volumeSetup != value) { _volumeSetup = value; VariablesChanged?.Invoke(); } }
        }
        public static string TubingIDSetup
        {
            get => _tubingIDSetup;
            set { if (_tubingIDSetup != value) { _tubingIDSetup = value; VariablesChanged?.Invoke(); } }
        }
        public static string PumpSpeedSetup
        {
            get => _pumpSpeedSetup;
            set { if (_pumpSpeedSetup != value) { _pumpSpeedSetup = value; VariablesChanged?.Invoke(); } }
        }
        public static string AntiDropSetup
        {
            get => _antiDropSetup;
            set { if (_antiDropSetup != value) { _antiDropSetup = value; VariablesChanged?.Invoke(); } }
        }

        public static string Parameters1
        {
            get => _parameters1;
            set { if (_parameters1 != value) { _parameters1 = value; VariablesChanged?.Invoke(); } }
        }
        public static string Parameters2
        {
            get => _parameters2;
            set { if (_parameters2 != value) { _parameters2 = value; VariablesChanged?.Invoke(); } }
        }

        public static string ProgramName_25
        {
            get => _programName25;
            set { if (_programName25 != value) { _programName25 = value; VariablesChanged?.Invoke(); } }
        }

        public static string ProgramName_26
        {
            get => _programName26;
            set { if (_programName26 != value) { _programName26 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Quanity3
        {
            get => _quanity3;
            set { if (_quanity3 != value) { _quanity3 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Volume3
        {
            get => _volume3;
            set { if (_volume3 != value) { _volume3 = value; VariablesChanged?.Invoke(); } }
        }

        public static string PumpSpeed3
        {
            get => _pumpSpeed3;
            set { if (_pumpSpeed3 != value) { _pumpSpeed3 = value; VariablesChanged?.Invoke(); } }
        }

        public static string TubeID3
        {
            get => _tubeID3;
            set { if (_tubeID3 != value) { _tubeID3 = value; VariablesChanged?.Invoke(); } }
        }

        public static string SpeedXY3
        {
            get => _speedXY3;
            set { if (_speedXY3 != value) { _speedXY3 = value; VariablesChanged?.Invoke(); } }
        }

        public static string AntiDrop3
        {
            get => _antidrop3;
            set { if (_antidrop3 != value) { _antidrop3 = value; VariablesChanged?.Invoke(); } }
        }
        public static string FillNumber
        {
            get => _fillNumber;
            set { if (_fillNumber != value) { _fillNumber = value; VariablesChanged?.Invoke(); } }
        }
        public static string ActualWeight
        {
            get => _actualWeight;
            set { if (_actualWeight != value) { _actualWeight = value; VariablesChanged?.Invoke(); } }
        }
        public static string Density
        {
            get => _density;
            set { if (_density != value) { _density = value; VariablesChanged?.Invoke(); } }
        }
        public static string FillNumberInformation
        {
            get => _fillNumberInformation;
            set { if (_fillNumberInformation != value) { _fillNumberInformation = value; VariablesChanged?.Invoke(); } }
        }
        public static string TimeRunInformation
        {
            get => _timeRunInformation;
            set { if (_timeRunInformation != value) { _timeRunInformation = value; VariablesChanged?.Invoke(); } }
        }
        public static string TimeDelayInformation
        {
            get => _timeDelayInformation;
            set { if (_timeDelayInformation != value) { _timeDelayInformation = value; VariablesChanged?.Invoke(); } }
        }
        public static string CyclesInformation
        {
            get => _cyclesInformation;
            set { if (_cyclesInformation != value) { _cyclesInformation = value; VariablesChanged?.Invoke(); } }
        }

        public static string Quanity4
        {
            get => _quanity4;
            set { if (_quanity4 != value) { _quanity4 = value; VariablesChanged?.Invoke(); } }
        }

        public static string Volume4
        {
            get => _volume4;
            set { if (_volume4 != value) { _volume4 = value; VariablesChanged?.Invoke(); } }
        }

        public static string PumpSpeed4
        {
            get => _pumpSpeed4;
            set { if (_pumpSpeed4 != value) { _pumpSpeed4 = value; VariablesChanged?.Invoke(); } }
        }

        public static string TubeID4
        {
            get => _tubeID4;
            set { if (_tubeID4 != value) { _tubeID4 = value; VariablesChanged?.Invoke(); } }
        }

        public static string SpeedXY4
        {
            get => _speedXY4;
            set { if (_speedXY4 != value) { _speedXY4 = value; VariablesChanged?.Invoke(); } }
        }

        public static string AntiDrop4
        {
            get => _antidrop4;
            set { if (_antidrop4 != value) { _antidrop4 = value; VariablesChanged?.Invoke(); } }
        }
        public static string HourInformation
        {
            get => _hourInformation;
            set { if (_hourInformation != value) { _hourInformation = value; VariablesChanged?.Invoke(); } }
        }
        public static string MinutesInformation
        {
            get => _minutesInformation;
            set { if (_minutesInformation != value) { _minutesInformation = value; VariablesChanged?.Invoke(); } }
        }
        public static string SecondInformation
        {
            get => _secondInformation;
            set { if (_secondInformation != value) { _secondInformation = value; VariablesChanged?.Invoke(); } }
        }
        public static bool resetHomeState
        {
            get => _resetHomeState;
            set { if (_resetHomeState != value) { _resetHomeState = value; VariablesChanged?.Invoke(); } }
        }

        public static bool Runned
        {
            get => _runned;
            set { if (_runned != value) { _runned = value; VariablesChanged?.Invoke(); } }
        }
    }
}
