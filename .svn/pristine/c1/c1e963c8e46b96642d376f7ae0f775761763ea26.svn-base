// *******************************************************************************
// **	Copyright(c) 2012-2014 Keyence Corporation. All rights reserved
// **	File Name: btLibDef.js
// **
// **	Function	: Terminal Library JavaScript File (Common data definitions)
// **	Notes		: None
// **
// ********************************************************************************

//Create Namespace
var Bt;
if( !Bt ){
	Bt = {};							// Namespace "Bt"
}
if( !Bt.LibDef ){
	Bt.LibDef = {};						// Namespace "Bt.LibDef"
}

//Functions in Namespace

(function() {

	var Def = Bt.LibDef;

	//====================================================================
	// Error code
	//====================================================================
	// 0.General #base=0
	Def.BT_OK									=    0;				// Success
	Def.BT_ERR									=   -1;				// Failure
	Def.BT_ERR_ARG_1							=	-11;			// Error argument (the 1st argument)
	Def.BT_ERR_ARG_2							=	-12;			// Error argument (the 2nd argument)
	Def.BT_ERR_ARG_3							=	-13;			// Error argument (the 3rd argument)

	// 1.System control  #base=-100
	Def.BT_ERR_SYS_SIP_NOTEXIST					=	-100;			// SIP panel that you specify does not exist in the terminal
	Def.BT_ERR_SYS_UPDATE_LOWVOLTAGE			=	-110;			// Update failure: Low voltage off
	Def.BT_ERR_SYS_UPDATE_NOTFOUND				=	-111;			// Update failure: Packag file not found
	Def.BT_ERR_SYS_UPDATE_INVALID				=	-112;			// Update failure: Invalid package
	Def.BT_ERR_SYS_UPDATE_UNSUPPORTED			=	-113;			// Update failure: Unsupported package (version mismatch)
	Def.BT_ERR_SYS_UPDATE_NOSPACE				=	-114;			// Update failure: Lack of free space
	Def.BT_ERR_SYS_UPDATE_ALREADY				=	-115;			// Update failure: Already updated
	Def.BT_ERR_SYS_NOT_ACTIVATED				=	-116;			// Function is not activated

	// 2.Communication control  #base=-200
	Def.BT_ERR_COMM_ALREADY_OPEN				=	-200;			// Target communication device is already opened
	Def.BT_ERR_COMM_NOTOPEN						=	-201;			// Target communication device is not opened
	Def.BT_ERR_COMM_INQUIRY_NODATA				=	-202;			// Inquiry (query) results does not exist
	Def.BT_ERR_COMM_CANCEL_INQUIRY				=	-203;			// Inquiry (query) has been canceled
	Def.BT_ERR_COMM_NOSERVICE					=	-204;			// Appropriate services can't be used at the remote device
	Def.BT_ERR_COMM_SPP_NOTCONNECT				=	-205;			// SPP connection has not been established
	Def.BT_ERR_COMM_SPP_CONNECTED				=	-211;			// SPP connection is established
	Def.BT_ERR_COMM_HSP_CONNECTED				=	-212;			// HSP connection is established
	Def.BT_ERR_COMM_DUN_CONNECTED				=	-213;			// DUN connection is established
	Def.BT_ERR_COMM_FTP_CONNECTED				=	-214;			// FTP connection is established
	Def.BT_ERR_COMM_PAN_CONNECTED				=	-215;			// PAN connection is established
	Def.BT_ERR_COMM_HID_CONNECTED				=	-216;			// HID connection is established
	Def.BT_ERR_COMM_PAIRING_FAILURE				=	-217;			// Pairing failure
	Def.BT_ERR_COMM_NOPAIR						=	-218;			// Can not find the pairing target
	Def.BT_ERR_COMM_DEV_PROCESSING				=	-219;			// Bluetooth device during operation
	Def.BT_ERR_COMM_INFO_PROCESSING				=	-220;			// Bluetooth adapter while setting
	Def.BT_ERR_COMM_INQUIRY_PROCESSING			=	-221;			// Running inquiry
	Def.BT_ERR_COMM_PAIR_PROCESSING				=	-222;			// Running pairing
	Def.BT_ERR_COMM_PROF_PROCESSING				=	-223;			// Various profiles of Bluetooth are running
	Def.BT_ERR_COMM_SNMP_DISABLE				=	-240;			// SNMP service is invalid
	Def.BT_ERR_COMM_SNMP_CONFIG					=	-241;			// Illegal SNMP settings
	Def.BT_ERR_COMM_SNMP_CONNECT				=	-242;			// Failed to connect SNMP host
	Def.BT_ERR_COMM_SNMP_TIMEOUT				=	-243;			// Failed to send SNMP information
	Def.BT_ERR_COMM_WLAN_SCAN_CHANNEL			=	-250;			// Unauthorized Wireless LAN parameters (Specification error scan channel :2.4GHz/5GHz)
	Def.BT_ERR_COMM_WLAN_SUPPORT_RATE			=	-251;			// Unauthorized Wireless LAN parameters (Specification error rate transmission)
	Def.BT_ERR_COMM_WLAN_BO_CHANNEL				=	-252;			// Unauthorized Wireless LAN parameters (Specification error of channel at the beacon owner)
	Def.BT_ERR_COMM_WLAN_CONNECT				=	-253;			// Wireless LAN connection failure (not found , or authentication failure)
	Def.BT_ERR_COMM_WLAN_DHCP_TIMEOUT			=	-254;			// Wireless LAN connection failure (DHCP timeout)
	Def.BT_ERR_COMM_WLAN_CERTIFICATE			=	-256;			// Registration certificate is invalid

	// 3.Scan control  #base=-300
	Def.BT_ERR_SCAN_READING						=	-300;			// 1D/2D code while reading
	Def.BT_ERR_SCAN_NODATA						=	-301;			// No code information that can be obtained
	Def.BT_ERR_SCAN_DISABLE						=	-302;			// Scan function is not valid
	Def.BT_ERR_SCAN_IGNORE						=	-303;			// Function call has been ignored
	Def.BT_ERR_SCAN_PARAM_JAN					=	-304;			// JAN setting error
	Def.BT_ERR_SCAN_PARAM_C39					=	-305;			// CODE39 setting error
	Def.BT_ERR_SCAN_PARAM_GS1_128				=	-306;			// GS1-128 setting error
	Def.BT_ERR_SCAN_PARAM_C128					=	-307;			// CODE128 setting error
	Def.BT_ERR_SCAN_PARAM_ITF					=	-308;			// ITF setting error
	Def.BT_ERR_SCAN_PARAM_NW7					=	-309;			// NW-7 setting error
	Def.BT_ERR_SCAN_PARAM_C93					=	-310;			// CODE93 setting error
	Def.BT_ERR_SCAN_PARAM_TOF					=	-311;			// Industrial2of5 setting error
	Def.BT_ERR_SCAN_PARAM_COOP					=	-312;			// COOP setting error
	Def.BT_ERR_SCAN_PARAM_GS1_DB				=	-313;			// GS1-DataBar setting error
	Def.BT_ERR_SCAN_PARAM_QR					=	-314;			// QR setting error
	Def.BT_ERR_SCAN_PARAM_PDF					=	-315;			// PDF setting error
	Def.BT_ERR_SCAN_PARAM_DM					=	-316;			// DataMatrix setting error
	Def.BT_ERR_SCAN_PARAM_MC					=	-317;			// MaxiCode setting error
	Def.BT_ERR_SCAN_PARAM_COMPOSITE				=	-318;			// COMPOSITE setting error
	Def.BT_ERR_SCAN_TYPE_ILLEGAL				=	-319;			// Invalid code type
	Def.BT_ERR_SCAN_CODE						=	-320;			// Invalid (non-regular) code
	Def.BT_ERR_SCAN_DIGIT						=	-321;			// Invalid digit code number
	Def.BT_ERR_SCAN_DIGIT_ADDON					=	-322;			// Invalid digit code number of the add-on
	Def.BT_ERR_SCAN_CODE_ADDON					=	-323;			// Invalid (non-regular) code of the add-on
	Def.BT_ERR_SCAN_CHECKDIGIT					=	-324;			// Invalid check digit
	Def.BT_ERR_SCAN_START_CHAR					=	-325;			// Invalid start character
	Def.BT_ERR_SCAN_STOP_CHAR					=	-326;			// Invalid stop character
	Def.BT_ERR_SCAN_SEND_STRING					=	-327;			// Failed to send a string
	Def.BT_ERR_SCAN_SET_CLIPBOARD				=	-328;			// Failed to write data to the clipboard
	Def.BT_ERR_SCAN_OCR_DIGIT_SHORTAGE			=	-350;			// Number of digits is insufficient
	Def.BT_ERR_SCAN_OCR_SPACE_ILLEGAL			=	-351;			// Invalid assignment of the space

	// 4.File control  #base=-400
	Def.BT_ERR_FILE_NOTFOUND					=	-400;			// File does not exist
	Def.BT_ERR_FILE_WRITE						=	-403;			// Failed to write file
	Def.BT_ERR_FILE_ALREADY_EXIST				=	-404;			// File already exists
	Def.BT_ERR_FILE_NOTOPEN						=	-414;			// File has not been opened
	Def.BT_ERR_FILE_ALREADY_OPEN				=	-415;			// File already opened
	Def.BT_ERR_FILE_EOF							=	-416;			// EOF (detect end of file)
	Def.BT_ERR_FILE_WAV_NODATA					=	-418;			// Specified WAV file is not registered

	//====================================================================
	// System control
	//====================================================================
	// Behavior
	Def.BT_OFF									=	0;				// OFF
	Def.BT_ON									=	1;				// ON

	// Version information
	Def.BT_SYS_OSVER_MAXLEN						=	5;				// Terminal OS version : string length (4-character number and 1-character dot)
	Def.BT_SYS_BLVER_MAXLEN						=	5;				// Boot Loader version : string length (4-character number and 1-character dot)

	// Devices
	Def.BT_DEV_LED								=	0x0001;				// LED
	Def.BT_DEV_VIB								=	0x0002;				// Vibrator
	Def.BT_DEV_BUZ								=	0x0004;				// Buzzer

	// LED
	Def.BT_LED_RED								=	0x01;													// Red
	Def.BT_LED_GREEN							=	0x02;													// Green
	Def.BT_LED_BLUE								=	0x04;													// Blue
	Def.BT_LED_YELLOW							=	Def.BT_LED_GREEN | Def.BT_LED_RED;						// Yellow
	Def.BT_LED_CYAN								=	Def.BT_LED_GREEN | Def.BT_LED_BLUE;						// Cyan
	Def.BT_LED_MAGENTA							=	Def.BT_LED_RED | Def.BT_LED_BLUE;						// Magenta
	Def.BT_LED_WHITE							=	Def.BT_LED_GREEN | Def.BT_LED_RED | Def.BT_LED_BLUE;	// White

	// Terminal parameter type
	Def.BT_SYS_PRM_HTTYPE						=	1;				// Model
	Def.BT_SYS_PRM_HTNAME						=	2;				// Terminal name
	Def.BT_SYS_PRM_GROUPNAME					=	3;				// Group name
	Def.BT_SYS_PRM_SERIALNO						=	4;				// Serial number

	Def.BT_SYS_HTTYPE_MAXLEN					=	16;				// Model : string length
	Def.BT_SYS_HTNAME_MAXLEN					=	32;				// Terminal name : string length
	Def.BT_SYS_GROUPNAME_MAXLEN					=	32;				// Group name : string length
	Def.BT_SYS_SERIALNO_MAXLEN					=	32;				// Serial number : string length

	// Battery level
	Def.BT_BATTERY_LV0							=	0;				// Level 0 (less than 5%)
	Def.BT_BATTERY_LV1							=	1;				// Level 1 (5-30%)
	Def.BT_BATTERY_LV2							=	2;				// Level 2 (30-50%)
	Def.BT_BATTERY_LV3							=	3;				// Level 3 (50% or more)
	Def.BT_BATTERY_LOWLV						=	8;				// Low voltage level
	Def.BT_BATTERY_AC							=	9;				// Connected AC

	// Key value assigned
	Def.BT_KEY_1								=	0x00000001;		// '1' key
	Def.BT_KEY_2								=	0x00000002;		// '2' key
	Def.BT_KEY_3								=	0x00000004;		// '3' key
	Def.BT_KEY_4								=	0x00000008;		// '4' key
	Def.BT_KEY_5								=	0x00000010;		// '5' key
	Def.BT_KEY_6								=	0x00000020;		// '6' key
	Def.BT_KEY_7								=	0x00000040;		// '7' key
	Def.BT_KEY_8								=	0x00000080;		// '8' key
	Def.BT_KEY_9								=	0x00000100;		// '9' key
	Def.BT_KEY_0								=	0x00000200;		// '0' key
	Def.BT_KEY_F1								=	0x00000400;		// 'F1' key
	Def.BT_KEY_F2								=	0x00000800;		// 'F2' key
	Def.BT_KEY_F3								=	0x00001000;		// 'F3' key
	Def.BT_KEY_F4								=	0x00002000;		// 'F4' key
	Def.BT_KEY_UP								=	0x00004000;		// UP key (cross)
	Def.BT_KEY_DOWN								=	0x00008000;		// DOWN key (cross)
	Def.BT_KEY_PERIOD							=	0x00010000;		// Period key
	Def.BT_KEY_MINUS							=	0x00020000;		// Minus key
	Def.BT_KEY_TAB								=	0x00040000;		// Tab key
	Def.BT_KEY_CHR								=	0x00080000;		// Character key
	Def.BT_KEY_STRG								=	0x00100000;		// Side trigger key
	Def.BT_KEY_ENT								=	0x00200000;		// ENT key
	Def.BT_KEY_CLR								=	0x00400000;		// Clear key
	Def.BT_KEY_FN								=	0x00800000;		// Fn key
	Def.BT_KEY_LEFT								=	0x01000000;		// LEFT key (cross)
	Def.BT_KEY_RIGHT							=	0x02000000;		// RIGHT key (cross)
	Def.BT_KEY_CTRG								=	0x04000000;		// Center trigger key (SCAN key)
	Def.BT_KEY_SHIFT							= 	0x08000000;		// Shift key
	Def.BT_KEY_ALL								=	0x07FFFFFF;		// All key(for BT-W100 series )
	Def.BT_KEY_DISABLEALL						=	0x00000000;		// Disable key (all keys except the power key)
	Def.BT_KEY_ENABLEALL						=	0xFFFFFFFF;		// Enable key (all keys except the power key)

	// Power off mode
	Def.BT_PW_SUSPEND							=	0;				// Suspend
	Def.BT_PW_RESET								=	1;				// Reset (Warm boot)

	// SIP panel name
	Def.BT_SIP_KEYBOARD							=	"LargeKB";				// For VGA
	Def.BT_SIP_KEYBOARD2						=	"キーボード";			// For QVGA
	Def.BT_SIP_KEYBOARD2W						=	"Keyboard";				// KEYBOARD2 other than Japanese UI
	Def.BT_SIP_KANA								=	"ひらがな/カタカナ";
	Def.BT_SIP_NUMERIC							=	"英数字";
	Def.BT_SIP_CYCLIC							=	"CYCLICSIP";
	Def.BT_SIP_SHUANGPIN						=	"ShuangPin IM 3D (for MSPY3)";		// For VGA
	Def.BT_SIP_SHUANGPIN2						=	"ShuangPin IM (for MSPY3)";			// For QVGA
	Def.BT_SIP_XAMLIM							=	"XAMLIM";

	// Character mode of key input
	Def.BT_KEYINPUT_HIRAGANA					=	1;				// Hiragana
	Def.BT_KEYINPUT_ZENKANA						=	2;				// Full-size katakana
	Def.BT_KEYINPUT_ZENEISUU					=	3;				// Full-size alphanumeric
	Def.BT_KEYINPUT_HANKANA						=	4;				// One-byte katakana
	Def.BT_KEYINPUT_HANEISUU					=	5;				// Alphanumeric
	Def.BT_KEYINPUT_DIRECT						=	6;				// Direct input # IME Off
	Def.BT_KEYINPUT_DIRECT2						=	7;				// Direct input # IME On

	// Accumulated log for User-defined
	Def.BT_LOG_COUNTLOG_MAX						=	64;				// Max number

	// Activation information
	Def.BT_FUNCTION_CODE_OCR					=	0;				// OCR function code

	//====================================================================
	// Scan control
	//====================================================================
	// Code type
	Def.BT_SCAN_CODE_JAN						=	1;				// JAN
	Def.BT_SCAN_CODE_C39						=	2;				// CODE39
	Def.BT_SCAN_CODE_GS1_128					=	3;				// GS1-128
	Def.BT_SCAN_CODE_C128						=	4;				// CODE128
	Def.BT_SCAN_CODE_ITF						=	5;				// ITF
	Def.BT_SCAN_CODE_NW7						=	6;				// NW-7
	Def.BT_SCAN_CODE_C93						=	7;				// CODE93
	Def.BT_SCAN_CODE_TOF						=	8;				// Industrial2of5
	Def.BT_SCAN_CODE_COOP						=	9;				// COOP
	Def.BT_SCAN_CODE_GS1_DB						=	10;				// GS1-DataBar
	Def.BT_SCAN_CODE_QR							=	11;				// QR
	Def.BT_SCAN_CODE_PDF						=	12;				// PDF
	Def.BT_SCAN_CODE_DM							=	13;				// DataMatrix
	Def.BT_SCAN_CODE_MC							=	14;				// MaxiCode
	Def.BT_SCAN_CODE_COMPOSITE					=	16;				// COMPOSITE
	Def.BT_SCAN_CODE_OCR						=	99;				// OCR
	Def.BT_SCAN_CODE_ANY						=	999;			// ANY (For multi code reading)

	// Code type (GS1-DataBar)
	Def.BT_SCAN_CODE_GS1_DB_EXP					=	0;				// GS1 DataBar Expanded
	Def.BT_SCAN_CODE_GS1_DB_EXP_ST				=	1;				// GS1 DataBar Expand Stacked
	Def.BT_SCAN_CODE_GS1_DB_14_LIM				=	2;				// GS1 DataBar Limited
	Def.BT_SCAN_CODE_GS1_DB_14					=	3;				// GS1 DataBar-14
	Def.BT_SCAN_CODE_GS1_DB_14_ST				=	4;				// GS1 DataBar-14 Stacked

	// Link information of the composite symbol
	Def.BT_SCAN_CMP_NOT_LINKED					=	0;				// Not a composite code
	Def.BT_SCAN_CMP_C128						=	1;				// Part of a composite code
	Def.BT_SCAN_CMP_GS1_DB						=	2;				// GS1-DataBar which is part of a composite code
	Def.BT_SCAN_CMP_CC_A						=	3;				// Two-dimensional code that make up the composite CC-A
	Def.BT_SCAN_CMP_CC_B						=	4;				// Two-dimensional code that make up the composite CC-B
	Def.BT_SCAN_CMP_CC_C						=	5;				// Two-dimensional code that make up the composite CC-C

	// Code permitted to read
	Def.BT_SCAN_ENABLE_JAN						=	0x00000001;		// JAN
	Def.BT_SCAN_ENABLE_C39						=	0x00000002;		// CODE39
	Def.BT_SCAN_ENABLE_GS1_128					=	0x00000004;		// GS1-128
	Def.BT_SCAN_ENABLE_C128						=	0x00000008;		// CODE128
	Def.BT_SCAN_ENABLE_ITF						=	0x00000010;		// ITF
	Def.BT_SCAN_ENABLE_NW7						=	0x00000020;		// NW-7
	Def.BT_SCAN_ENABLE_C93						=	0x00000040;		// CODE93
	Def.BT_SCAN_ENABLE_TOF						=	0x00000080;		// Industrial2of5
	Def.BT_SCAN_ENABLE_COOP						=	0x00000100;		// COOP
	Def.BT_SCAN_ENABLE_GS1_DB					=	0x00000200;		// GS1-DataBar
	Def.BT_SCAN_ENABLE_QR						=	0x00000400;		// QR
	Def.BT_SCAN_ENABLE_PDF						=	0x00000800;		// PDF
	Def.BT_SCAN_ENABLE_DM						=	0x00001000;		// DataMatrix
	Def.BT_SCAN_ENABLE_MC						=	0x00002000;		// MaxiCode
	Def.BT_SCAN_ENABLE_COMPOSITE				=	0x00008000;		// COMPOSITE
	Def.BT_SCAN_ENABLE_ALL						=	0x0000BFFF;		// All code

	// Trigger mode
	Def.BT_SCAN_AUTO_OFF						=	0;				// Auto Off
	Def.BT_SCAN_MOMENTARY						=	1;				// Momentary
	Def.BT_SCAN_DOUBLECLICK						=	2;				// Double Click
	Def.BT_SCAN_RELEASE							=	3;				// Trigger at release
	Def.BT_SCAN_CONTINUOUS						=	4;				// Continuous

	// Inversion
	Def.BT_SCAN_POSITIVE						=	1;				// Color inversion: Black on white
	Def.BT_SCAN_NEGATIVE						=	2;				// Color inversion: White on black
	Def.BT_SCAN_NEGAPOSI						=	(Def.BT_SCAN_POSITIVE | Def.BT_SCAN_NEGATIVE);	// Color inversion: Both
	Def.BT_SCAN_UNMIRRORD						=	4;				// Mirror inversion: Off
	Def.BT_SCAN_MIRRORD							=	8;				// Mirror inversion: On

	// Scan Level
	Def.BT_SCAN_LOW								=	0;				// [1D]Flexible # reserved at 2D (Treated the same as "1")
	Def.BT_SCAN_MID								=	1;				// [1D/2D]Normal
	Def.BT_SCAN_HIGH							=	2;				// [1D]Strict, [2D]Contemplate
	Def.BT_SCAN_ROBUST_DEF						=	3;				// [2D]Deflate
	Def.BT_SCAN_ROBUST_INF						=	4;				// [2D]Inflate
	Def.BT_SCAN_ROBUST_GAU						=	5;				// [2D]Smoothing Filter (Protection against noise)
	Def.BT_SCAN_HIGH1							=	6;				// [2D]Contemplate(pattern_1)
	Def.BT_SCAN_HIGH2							=	7;				// [2D]Contemplate(pattern_2)
	Def.BT_SCAN_DISTANCE						=	9;				// [2D]High resolution
	Def.BT_SCAN_DPM								=	29;				// [2D]DPM

	// Scan range(2D)
	Def.BT_SCAN_RANGE_FIRST						=	1;				// Decode only the code that found first
	Def.BT_SCAN_RANGE_CENTER					=	2;				// Decode only the code that is located the center of marker
	Def.BT_SCAN_RANGE_FULL						=	3;				// Only Multi code
	Def.BT_SCAN_RANGE_LINE						=	4;				// Decode only the code that is located the center line (y-axis)
	Def.BT_SCAN_RANGE_LIMITED					=	5;				// Limited view of decode target

	// External lighting(2D)
	Def.BT_SCAN_EXT_LIGHT_NORMAL				=	0x0001;			// Internal lighting
	Def.BT_SCAN_EXT_LIGHT_MULTI					=	0x0002;			// Multi-angle lighting
	Def.BT_SCAN_EXT_LIGHT_LOW					=	0x0004;			// Low angle lighting
	Def.BT_SCAN_EXT_LIGHT_3D					=	0x0008;			// (Reserved) 3D character reading lighting
	Def.BT_SCAN_EXT_LIGHT_ALL					=	0x000F;

	// (Reserved) 3D character reading(2D)
	Def.BT_SCAN_3D_MODE_RECESSED				=	0x0001;			// (Reserved) 3D character reading (Recessed)
	Def.BT_SCAN_3D_MODE_RAISED					=	0x0002;			// (Reserved) 3D character reading (Raised)
	Def.BT_SCAN_3D_MODE_ALL						=	0x0003;			// (Reserved) 3D character reading (Recessed + Raised)

	// Target area(2D)
	Def.BT_SCAN_EXT_LIGHT_AREA_SMALL			=	0;				// Small
	Def.BT_SCAN_EXT_LIGHT_AREA_MIDDLE			=	1;				// Middle
	Def.BT_SCAN_EXT_LIGHT_AREA_LARGE			=	2;				// Large

	// Scan property ID
	// 1D/2D code
	Def.BT_SCAN_PROP_JAN						=	0x00001000;		// JAN property
	Def.BT_SCAN_PROP_CODE39						=	0x00001100;		// Code39 property
	Def.BT_SCAN_PROP_CODE128					=	0x00001200;		// Code128 property
	Def.BT_SCAN_PROP_GS1_128					=	0x00001300;		// GS1-128 property
	Def.BT_SCAN_PROP_NW7						=	0x00001400;		// NW7 property
	Def.BT_SCAN_PROP_ITF						=	0x00001500;		// ITF property
	Def.BT_SCAN_PROP_CODE93						=	0x00001600;		// Code93 property
	Def.BT_SCAN_PROP_TOF						=	0x00001700;		// TOF property
	Def.BT_SCAN_PROP_COOP						=	0x00001800;		// COOP property
	Def.BT_SCAN_PROP_QR							=	0x00002000;		// QR property
	Def.BT_SCAN_PROP_PDF						=	0x00002100;		// PDF417 property
	Def.BT_SCAN_PROP_DM							=	0x00002200;		// DataMatrix property
	Def.BT_SCAN_PROP_MC							=	0x00002300;		// MaxiCode property
	Def.BT_SCAN_PROP_GS1_DB						=	0x00002400;		// GS1 DataBar property
	Def.BT_SCAN_PROP_COMPOSITE					=	0x00002500;		// Composite symbol property

	// General
	Def.BT_SCAN_PROP_ENABLE_SYMBOLS				=	0x00000C00;		// Code permitted to read
	Def.BT_SCAN_PROP_FULLDETECTION				=	0x00000D00;		// Multi code setting
	Def.BT_SCAN_PROP_CODELINK					=	0x00000F01;		// Barcode link function

	// Action at reading
	Def.BT_SCAN_PROP_SCAN_TIMEOUT				=	0x00000200;		// Scan timeout
	Def.BT_SCAN_PROP_DECODE_TIMEOUT				=	0x00000300;		// Decode timeout
	Def.BT_SCAN_PROP_CONTINUOUS_TIME			=	0x00000400;		// Prevention time of twice reading
	Def.BT_SCAN_PROP_SUCCESS_TIMES				=	0x00000500;		// Matching times
	Def.BT_SCAN_PROP_SCAN_TYPE					=	0x00000700;		// Scan type
	Def.BT_SCAN_PROP_SCAN_LEVEL					=	0x00000800;		// Scan Level
	Def.BT_SCAN_PROP_INVERSE					=	0x00000900;		// Inversion code reading
	Def.BT_SCAN_PROP_ILLUMINATION				=	0x00000F02;		// Lighting control
	Def.BT_SCAN_PROP_TRIGGER_MODE				=	0x00001002;		// Trigger mode
	Def.BT_SCAN_PROP_CLRKEY_MODE				=	0x00001003;		// Cancel key setting
	Def.BT_SCAN_PROP_SEPARATOR_COUNT			=	0x00001004;		// Count the number of separator digits
	Def.BT_SCAN_PROP_COMPLETE_LED				=	0x00001005;		// Read Success: LED
	Def.BT_SCAN_PROP_COMPLETE_VIB				=	0x00001006;		// Read Success: Vibrator
	Def.BT_SCAN_PROP_COMPLETE_BUZ				=	0x00001007;		// Read Success: Buzzer
	Def.BT_SCAN_PROP_STIMEOUT_LED				=	0x00001008;		// Scan Timeout: LED
	Def.BT_SCAN_PROP_STIMEOUT_VIB				=	0x00001009;		// Scan Timeout: Vibrator
	Def.BT_SCAN_PROP_STIMEOUT_BUZ				=	0x00001010;		// Scan Timeout: Buzzer
	Def.BT_SCAN_PROP_DTIMEOUT_LED				=	0x00001011;		// Decode Timeout: LED
	Def.BT_SCAN_PROP_DTIMEOUT_VIB				=	0x00001012;		// Decode Timeout: Vibrator
	Def.BT_SCAN_PROP_DTIMEOUT_BUZ				=	0x00001013;		// Decode Timeout: Buzzer
	Def.BT_SCAN_PROP_CANCEL_LED					=	0x00001014;		// Cancel at reading: LED
	Def.BT_SCAN_PROP_CANCEL_VIB					=	0x00001015;		// Cancel at reading: Vibrator
	Def.BT_SCAN_PROP_CANCEL_BUZ					=	0x00001016;		// Cancel at reading: Buzzer
	Def.BT_SCAN_PROP_SEPARATOR_CODE				=	0x00001017;		// Separator code
	Def.BT_SCAN_PROP_FOCUS_MODE					=	0x00004A00;		// [2D]Focus mode
	Def.BT_SCAN_PROP_INIT_FOCUS_POS				=	0x00004A40;		// [2D]Focus position for auto focus
	Def.BT_SCAN_PROP_FIXED_FOCUS_POS			=	0x00004A50;		// [2D]Focus position for fixed focus
	Def.BT_SCAN_PROP_EXT_ILLUMINATION			=	0x00004A90;		// [2D]External lighting
	Def.BT_SCAN_PROP_3D_ILLUMINATION			=	0x000055B0;		// (Reserved) [2D]3D character reading
	Def.BT_SCAN_PROP_LIVEVIEW_DECODING			=	0x00004AA0;		// [2D]Display liveview decoding
	Def.BT_SCAN_PROP_TARGET_BRIGHTNESS			=	0x00004AC0;		// [2D]Target brightness
	Def.BT_SCAN_PROP_DISTANCE_LED				= 	0x00004AD0;		// [2D]Reading distance display LED
	Def.BT_SCAN_PROP_LASER_MODE					=	0x00010000;		// [1D]Laser mode

	// OCR
	Def.BT_SCAN_PROP_OCR_ALERT_ENABLE_DEV		=	0x00001018;		// OCR Alert: Device Enable/Disable
	Def.BT_SCAN_PROP_OCR_ALERT_LED				=	0x00001019;		// OCR Alert: LED
	Def.BT_SCAN_PROP_OCR_ALERT_VIB				=	0x0000101A;		// OCR Alert: Vibrator
	Def.BT_SCAN_PROP_OCR_ALERT_BUZ				=	0x0000101B;		// OCR Alert: Buzzer
	Def.BT_SCAN_PROP_OCR_DISP_CHECK				=	0x0000101C;		// Display of the recognition result and editing
	Def.BT_SCAN_PROP_OCR_ENABLE_COMBI			=	0x00005100;		// Combination of reading
	Def.BT_SCAN_PROP_OCR_RMODE					=	0x00005110;		// OCR Reading mode
	Def.BT_SCAN_PROP_OCR_RPATTERN				=	0x00005120;		// OCR Recognition pattern
	Def.BT_SCAN_PROP_OCR_INVERSE				=	0x00005130;		// OCR Color inversion
	Def.BT_SCAN_PROP_OCR_CHAR_SIZE				=	0x00005140;		// Enable the reading of small text size
	Def.BT_SCAN_PROP_OCR_ROTATE					=	0x00005150;		// Direction to be read
	Def.BT_SCAN_PROP_OCR_SFORMAT				=	0x00005160;		// Range restriction
	Def.BT_SCAN_PROP_OCR_DFORMAT				=	0x00005170;		// Format registration
	Def.BT_SCAN_PROP_OCR_AD_DIGIT				=	0x00005180;		// A.D. digit
	Def.BT_SCAN_PROP_OCR_DAY_EXIST				=	0x00005190;		// Date notation
	Def.BT_SCAN_PROP_OCR_1DIGIT_MM_DD			=	0x000051A0;		// Read month, day of 1-digit
	Def.BT_SCAN_PROP_OCR_ERA					=	0x000051B0;		// Read Japanese calendar
	Def.BT_SCAN_PROP_OCR_RECOG_DATE				=	0x000051C0;		// Date recognition range
	Def.BT_SCAN_PROP_OCR_DATE_DELIM				=	0x000051D0;		// Date separator
	Def.BT_SCAN_PROP_OCR_OUT_DATE_FORMAT		=	0x000051E0;		// Date output pattern
	Def.BT_SCAN_PROP_OCR_OUT_DATE_DELIM			=	0x000051F0;		// Date output separator
	Def.BT_SCAN_PROP_OCR_OUT_ALERT_THRESH		=	0x00005200;		// Alert frequency
	Def.BT_SCAN_PROP_OCR_CONTINUOUS_MARK		=	0x00005210;		// Enable the reading of continuous mark
	Def.BT_SCAN_PROP_OCR_MARK_SKIP				=	0x00005220;		// Set output pattern of read marks as result
	Def.BT_SCAN_PROP_OCR_OUT_ALERT_NOTSUCCESS	=	0x00005230;		// Fail reading when alert occurs
	Def.BT_SCAN_PROP_OCR_SHORT_DIGIT			=	0x00005240;		// Enable one/two digits reading
	Def.BT_SCAN_PROP_OCR_VMARGIN				=	0x00005250;		// Enable with no margin top and bottom
	Def.BT_SCAN_PROP_OCR_HEIGHT_UNEVEN			=	0x00005260;		// Enable reading of height is uneven
	Def.BT_SCAN_PROP_OCR_ACROSS_BORDER			=	0x00005270;		// Enable reading across the border
	Def.BT_SCAN_PROP_OCR_EASE_FAILURE			=	0x00005280;		// Enable reading of unreliable string (Fail reading increases)
	Def.BT_SCAN_PROP_OCR_PASSPORT_CHECK_DIGIT			=	0x00005290;		// Enable check digits (for passport reading)
	Def.BT_SCAN_PROP_OCR_PASSPORT_IGNORE_OPTIONAL_DATA	=	0x000052A0;		// Enable ignore optional data (for passport reading)
	Def.BT_SCAN_PROP_OCR_PASSPORT_CHECK_ICAO_FORMAT		=	0x000052B0;		// Enable ICAO format check (for passport reading)
	Def.BT_SCAN_PROP_OCR_DATE_ORDER				= 	0x00005400;		// Date order format
	Def.BT_SCAN_PROP_OCR_M_ALPHABET				= 	0x00005410;		// Read alphabet month
	Def.BT_SCAN_PROP_OCR_D_KANJI_BME			= 	0x00005420;		// Read "上”, “中”, “下"	#Kanji in Japanese
	Def.BT_SCAN_PROP_OCR_REPL_B					= 	0x00005430;		// A day converted from “上”	#Kanji in Japanese
	Def.BT_SCAN_PROP_OCR_REPL_M					= 	0x00005440;		// A day converted from “中”	#Kanji in Japanese
	Def.BT_SCAN_PROP_OCR_REPL_E					= 	0x00005450;		// A day converted from “下”	#Kanji in Japanese
	Def.BT_SCAN_PROP_OCR_BG_PATTERN				= 	0x00005460;		// Enable reading on the patterns
	Def.BT_SCAN_PROP_OCR_BG_PATTERN_DEPTH		= 	0x00005470;		// Depth of background patterns
	Def.BT_SCAN_PROP_OCR_LOWERCASE_ALPHABET		=	0x000054D0;		// Enable the reading of lowercase characters
	Def.BT_SCAN_PROP_OCR_7SEG_MODE				=	0x000054E0;		// 7-segment character string reading mode
	Def.BT_SCAN_PROP_OCR_REMOVE_RULED_LINE		=	0x00005500;		// Delete straight lines.
	Def.BT_SCAN_PROP_OCR_OUTPUT_SPACE			=	0x00005510;		// Add spaces identified in the read data
	Def.BT_SCAN_PROP_OCR_MULTI_STR				=	0x00005520;		// Batch reading of multiple character strings
	Def.BT_SCAN_PROP_OCR_TOUCHED_CHAR_TB		=	0x00005530;		// Contacting characters (vertical)
	Def.BT_SCAN_PROP_OCR_TOUCHED_CHAR_LR		=	0x00005540;		// Contacting characters (horizontal)
	Def.BT_SCAN_PROP_OCR_DISP_DATE_CHOICE		=	0x00005550;		// Date candidate selection screen display
	Def.BT_SCAN_PROP_OCR_STR_OUTPUT_FORMAT		=	0x00005570;		// Excluded character specification
	Def.BT_SCAN_PROP_OCR_CUTOUT_MODE			=	0x00005580;		// Reading range
	Def.BT_SCAN_PROP_OCR_DETECTION_MODE			=	0x00005590;		// Detection mode
	Def.BT_SCAN_PROP_OCR_DATE_CHOICE_DELIM		=	0x000055A0;		// Inter-candidate separator code for date selection
	Def.BT_SCAN_PROP_OCR_MIRROR					=	0x000055C0;		// Mirror



	// Max value of multi code reading
	Def.BT_SCAN_FD_CODESET_MAX					=	4;				// Number of codes that can be specified at multi code
	Def.BT_SCAN_FD_COLUMN_MAX					=	4;				// Number of stages per one code that can be specified at multi code

	// Additional key code
	Def.BT_SCAN_KEY_NONE						=	0x80;			// None
	Def.BT_SCAN_KEY_TAB							=	0x81;			// TAB key
	Def.BT_SCAN_KEY_SFTTAB						=	0x82;			// Shift+TAB key
	Def.BT_SCAN_KEY_ENT							=	0x83;			// ENT key
	Def.BT_SCAN_KEY_CR							=	0x84;			// CR
	Def.BT_SCAN_KEY_LF							=	0x85;			// LF
	Def.BT_SCAN_KEY_CRLF						=	0x86;			// CR+LF

	// Focus mode (2D)
	Def.BT_SCAN_FOCUS_MODE_AUTO			=	0;			// Auto focus
	Def.BT_SCAN_FOCUS_MODE_FIXED			=	1;			// Fixed focus

	// Focus position (2D)
	Def.BT_SCAN_FOCUS_POS_NEAR			=	60;			// Near
	Def.BT_SCAN_FOCUS_POS_MID			=	180;			// Middle
	Def.BT_SCAN_FOCUS_POS_FAR			=	450;			// Far
	Def.BT_SCAN_FOCUS_POS_MEMORY			=	-180;			// Previous value of decode success

	// Laser mode (1D)
	Def.BT_SCAN_LASER_MODE_WIDE			=	1;			// Laser width: Wide (Middle distance)
	Def.BT_SCAN_LASER_MODE_NARROW			=	2;			// Laser width: Narrow (Far distance)
	Def.BT_SCAN_LASER_MODE_AUTO			=	3;			// Laser width: Auto

	// [OCR] Combination of reading (BT_SCAN_PROP_OCR_ENABLE_COMBI)
	Def.BT_SCAN_OCR_ENABLE_PLUS					=	1;				// Enable OCR Reading (OCR + 1D/2D)
	Def.BT_SCAN_OCR_ENABLE_ONLY					=	2;				// Enable OCR Reading (only)
	Def.BT_SCAN_OCR_DISABLE						=	3;				// Disable OCR Reading

	// [OCR] OCR Reading mode (BT_SCAN_PROP_OCR_RMODE)
	Def.BT_SCAN_OCR_RMODE_SPEED					=	1;				// Speed
	Def.BT_SCAN_OCR_RMODE_CONTEMPLATE			=	2;				// Contemplate

	// [OCR] OCR Recognition pattern (BT_SCAN_PROP_OCR_RPATTERN)
	Def.BT_SCAN_OCR_RPATTERN_FREE				=	1;				// String
	Def.BT_SCAN_OCR_RPATTERN_DATE				=	2;				// Date
	Def.BT_SCAN_OCR_RPATTERN_PASSPORT			=	3;				// Passport

	// [OCR] Enable the reading of small text size (BT_SCAN_PROP_OCR_CHAR_SIZE)
	// BT_ON/BT_OFF

	// [OCR] Direction to be read (BT_SCAN_PROP_OCR_ROTATE)
	Def.BT_SCAN_OCR_ANGLE_0					=	0x0001;				// 0 degrees
	Def.BT_SCAN_OCR_ANGLE_180				=	0x0002;				// 180 degrees
	Def.BT_SCAN_OCR_ANGLE_BOTH				=	0x0003;				// Both (0/180 degrees)

	// [OCR] Range restriction (BT_SCAN_PROP_OCR_SFORMAT)
	// Character type
	Def.BT_SCAN_OCR_CHARTYPE_DIGIT				=	0x0001;			// Number
	Def.BT_SCAN_OCR_CHARTYPE_ALPHABET			=	0x0002;			// Alphabet(upper case)
	Def.BT_SCAN_OCR_CHARTYPE_MARK				=	0x0004;			// Mark
	Def.BT_SCAN_OCR_CHARTYPE_L_ALPHABET			=	0x0008;			// Alphabet(lower case)
	Def.BT_SCAN_OCR_CHARTYPE_ALL				=	0x000F;			// All
	// Character type
	Def.BT_SCAN_OCR_CHAR_RANGE_MIN				=	1;				// Minimum
	Def.BT_SCAN_OCR_CHAR_RANGE_MAX				=	30;				// Maximum
	// Margin (Left/Right)
	// BT_ON/BT_OFF

	// [OCR] Format registration (BT_SCAN_PROP_OCR_DFORMAT)
	Def.BT_SCAN_OCR_DFMT_BANK_MIN				=	1;				// Minimum number of format registration
	Def.BT_SCAN_OCR_DFMT_BANK_MAX				=	50;				// Maximum number of format registration

	Def.BT_SCAN_OCR_DFMT_CHAR_MODE_CHAR			=	1;				// Number / Alphabet / Mark
	Def.BT_SCAN_OCR_DFMT_CHAR_MODE_SPACE		=	2;				// Space

	// Reading rule of one character at a time (Number)
	Def.BT_SCAN_OCR_DFMT_EACH_0					=	0x00000001;		// '0'
	Def.BT_SCAN_OCR_DFMT_EACH_1					=	0x00000002;		// '1'
	Def.BT_SCAN_OCR_DFMT_EACH_2					=	0x00000004;		// '2'
	Def.BT_SCAN_OCR_DFMT_EACH_3					=	0x00000008;		// '3'
	Def.BT_SCAN_OCR_DFMT_EACH_4					=	0x00000010;		// '4'
	Def.BT_SCAN_OCR_DFMT_EACH_5					=	0x00000020;		// '5'
	Def.BT_SCAN_OCR_DFMT_EACH_6					=	0x00000040;		// '6'
	Def.BT_SCAN_OCR_DFMT_EACH_7					=	0x00000080;		// '7'
	Def.BT_SCAN_OCR_DFMT_EACH_8					=	0x00000100;		// '8'
	Def.BT_SCAN_OCR_DFMT_EACH_9					=	0x00000200;		// '9'
	Def.BT_SCAN_OCR_DFMT_EACH_NUM_ALL			=	0x000003FF;		// ALL

	// Reading rule of one character at a time (Alphabet)
	Def.BT_SCAN_OCR_DFMT_EACH_A					=	0x00000001;		// 'A'
	Def.BT_SCAN_OCR_DFMT_EACH_B					=	0x00000002;		// 'B'
	Def.BT_SCAN_OCR_DFMT_EACH_C					=	0x00000004;		// 'C'
	Def.BT_SCAN_OCR_DFMT_EACH_D					=	0x00000008;		// 'D'
	Def.BT_SCAN_OCR_DFMT_EACH_E					=	0x00000010;		// 'E'
	Def.BT_SCAN_OCR_DFMT_EACH_F					=	0x00000020;		// 'F'
	Def.BT_SCAN_OCR_DFMT_EACH_G					=	0x00000040;		// 'G'
	Def.BT_SCAN_OCR_DFMT_EACH_H					=	0x00000080;		// 'H'
	Def.BT_SCAN_OCR_DFMT_EACH_I					=	0x00000100;		// 'I'
	Def.BT_SCAN_OCR_DFMT_EACH_J					=	0x00000200;		// 'J'
	Def.BT_SCAN_OCR_DFMT_EACH_K					=	0x00000400;		// 'K'
	Def.BT_SCAN_OCR_DFMT_EACH_L					=	0x00000800;		// 'L'
	Def.BT_SCAN_OCR_DFMT_EACH_M					=	0x00001000;		// 'M'
	Def.BT_SCAN_OCR_DFMT_EACH_N					=	0x00002000;		// 'N'
	Def.BT_SCAN_OCR_DFMT_EACH_O					=	0x00004000;		// 'O'
	Def.BT_SCAN_OCR_DFMT_EACH_P					=	0x00008000;		// 'P'
	Def.BT_SCAN_OCR_DFMT_EACH_Q					=	0x00010000;		// 'Q'
	Def.BT_SCAN_OCR_DFMT_EACH_R					=	0x00020000;		// 'R'
	Def.BT_SCAN_OCR_DFMT_EACH_S					=	0x00040000;		// 'S'
	Def.BT_SCAN_OCR_DFMT_EACH_T					=	0x00080000;		// 'T'
	Def.BT_SCAN_OCR_DFMT_EACH_U					=	0x00100000;		// 'U'
	Def.BT_SCAN_OCR_DFMT_EACH_V					=	0x00200000;		// 'V'
	Def.BT_SCAN_OCR_DFMT_EACH_W					=	0x00400000;		// 'W'
	Def.BT_SCAN_OCR_DFMT_EACH_X					=	0x00800000;		// 'X'
	Def.BT_SCAN_OCR_DFMT_EACH_Y					=	0x01000000;		// 'Y'
	Def.BT_SCAN_OCR_DFMT_EACH_Z					=	0x02000000;		// 'Z'
	Def.BT_SCAN_OCR_DFMT_EACH_ALPH_ALL			=	0x03FFFFFF;		// ALL

	// Reading rule of one character at a time (Mark)
	Def.BT_SCAN_OCR_DFMT_EACH_HYPHEN			=	0x00000001;		// '-'
	Def.BT_SCAN_OCR_DFMT_EACH_PERIOD			=	0x00000002;		// '.'
	Def.BT_SCAN_OCR_DFMT_EACH_COLON				=	0x00000004;		// ':'
	Def.BT_SCAN_OCR_DFMT_EACH_SLASH				=	0x00000008;		// '/'
	Def.BT_SCAN_OCR_DFMT_EACH_PARENTHESIS_B		=	0x00000010;		// '('
	Def.BT_SCAN_OCR_DFMT_EACH_PARENTHESIS_E		=	0x00000020;		// ')'
	Def.BT_SCAN_OCR_DFMT_EACH_SHARP				=	0x00000040;		// '#'
	Def.BT_SCAN_OCR_DFMT_EACH_ASTERISK			=	0x00000080;		// '*'
	Def.BT_SCAN_OCR_DFMT_EACH_YEN				=	0x00000100;		// '\'
	Def.BT_SCAN_OCR_DFMT_EACH_PLUS				=	0x00000200;		// '+'
	Def.BT_SCAN_OCR_DFMT_EACH_MARKS_ALL			=	0x000003FF;		// ALL

	// [OCR] A.D. digit (BT_SCAN_PROP_OCR_AD_DIGIT)
	Def.BT_SCAN_OCR_AD_2DIGIT					=	0x0001;			// 2-digits of A.D.
	Def.BT_SCAN_OCR_AD_4DIGIT					=	0x0002;			// 4-digits of A.D.
	Def.BT_SCAN_OCR_AD_2_4DIGIT					=	0x0003;			// Both (2/4-digits of A.D.)

	// [OCR] Date notation (BT_SCAN_PROP_OCR_DAY_EXIST)
	Def.BT_SCAN_OCR_DAY_EXIST					=	0x0001;			// Only if the date is included
	Def.BT_SCAN_OCR_DAY_NOTEXIST				=	0x0002;			// Only if the date is not included
	Def.BT_SCAN_OCR_DAY_BOTH					=	0x0003;			// Both (date is included / not included)

	// [OCR] Read month, day of 1-digit (BT_SCAN_PROP_OCR_1DIGIT_MM_DD)
	// BT_ON/BT_OFF

	// [OCR] Date separator (BT_SCAN_PROP_OCR_DATE_DELIM)
	Def.BT_SCAN_OCR_DATE_DELIM_SLASH			=	0x0001;			// Slash
	Def.BT_SCAN_OCR_DATE_DELIM_PERIOD			=	0x0002;			// Period
	Def.BT_SCAN_OCR_DATE_DELIM_HYPHEN			=	0x0004;			// Hyphen
	Def.BT_SCAN_OCR_DATE_DELIM_SPACE			=	0x0008;			// Space
	Def.BT_SCAN_OCR_DATE_DELIM_MD_KANJI			=	0x0010;			// “年”,”月” #Kanji in Japanese
	Def.BT_SCAN_OCR_DATE_DELIM_NONE				=	0x0020;			// Non-delimited
	Def.BT_SCAN_OCR_DATE_DELIM_ALL				=	0x003F;			// All

	// [OCR] Read Japanese calendar (BT_SCAN_PROP_OCR_ERA)
	Def.BT_SCAN_OCR_ERA_MAX						=	2;				// Number of Japanese calendar settings
	Def.BT_SCAN_OCR_ERA_FIRSTYEAR_MIN			=	1989;			// Minimum year of the Japanese calendar (converted to A.D.)
	Def.BT_SCAN_OCR_ERA_FIRSTYEAR_MAX			=	2039;			// Maximum year of the Japanese calendar (converted to A.D.)
	Def.BT_SCAN_OCR_ERA_RANGE_MIN				=	1;				// Minimum year of the Japanese calendar
	Def.BT_SCAN_OCR_ERA_RANGE_MAX				=	99;				// Maximum year of the Japanese calendar

	// [OCR] Date output pattern (BT_SCAN_PROP_OCR_OUT_DATE_FORMAT)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_YYYYMMDD	=	1;				// YYYYMMDD (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_YYYYMM		=	2;				// YYYYMM (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_YYMMDD		=	3;				// YYMMDD (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_YYMM		=	4;				// YYMM (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_MMDDYYYY	=	5;				// MMDDYYYY (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_MMYYYY		=	6;				// MMYYYY (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_MMDDYY		=	7;				// MMDDYY (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_MMYY		=	8;				// MMYY (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_DDMMYYYY	=	9;				// DDMMYYYY (A.D.)
	Def.BT_SCAN_OCR_OUT_DATE_FORMAT_DDMMYY		=	10;				// DDMMYY (A.D.)

	// [OCR] Date Order (BT_SCAN_PROP_OCR_DATE_ORDER)
	Def.BT_SCAN_PROP_OCR_DATE_ORDER_YMD			=	0x0001;			// YMD order
	Def.BT_SCAN_PROP_OCR_DATE_ORDER_DMY			=	0x0002;			// DMY order
	Def.BT_SCAN_PROP_OCR_DATE_ORDER_MDY			=	0x0004;			// MDY order
	Def.BT_SCAN_PROP_OCR_DATE_ORDER_AUTO		=	0x0008;			// Automatic distinction

	// [OCR] Depth of background patterns (BT_SCAN_PROP_OCR_BG_PATTERN_DEPTH)
	Def.BT_SCAN_PROP_OCR_BG_PATTERN_DEPTH_THIN	=	1;				// Thin
	Def.BT_SCAN_PROP_OCR_BG_PATTERN_DEPTH_DARK	=	2;				// Dark

	// [OCR] Date output separator (BT_SCAN_PROP_OCR_OUT_DATE_DELIM)
	Def.BT_SCAN_OCR_OUT_DATE_DELIM_NONE			=	0;				// Non-delimited
	Def.BT_SCAN_OCR_OUT_DATE_DELIM_SLASH		=	1;				// Slash
	Def.BT_SCAN_OCR_OUT_DATE_DELIM_PERIOD		=	2;				// Period
	Def.BT_SCAN_OCR_OUT_DATE_DELIM_HYPHEN		=	3;				// Hyphen
	Def.BT_SCAN_OCR_OUT_DATE_DELIM_SPACE		=	4;				// Space

	// [OCR] Alert frequency (BT_SCAN_PROP_OCR_OUT_ALERT_THRESH)
	Def.BT_SCAN_OCR_OUT_ALERT_THRESH_LOW		=	1;				// Sensitive
	Def.BT_SCAN_OCR_OUT_ALERT_THRESH_MID		=	2;				// Normal
	Def.BT_SCAN_OCR_OUT_ALERT_THRESH_HIGH		=	3;				// Insensitive

	// [OCR] Display of the recognition result and editing (BT_SCAN_PROP_OCR_DISP_CHECK)
	Def.BT_SCAN_OCR_OUT_DISP_CHECK_NONE			=	0;				// Do not display
	Def.BT_SCAN_OCR_OUT_DISP_CHECK_EVERYTIME	=	1;				// Display every time
	Def.BT_SCAN_OCR_OUT_DISP_CHECK_ONALERT		=	2;				// Display when an alert occurs

	// [OCR] Alert information (result)
	Def.BT_SCAN_OCR_OUT_ALERT_TYPE_NONE			=	0x0000;			// No alert
	Def.BT_SCAN_OCR_OUT_ALERT_TYPE_ACCURACY		=	0x0001;			// Detect with low accuracy
	Def.BT_SCAN_OCR_OUT_ALERT_TYPE_CHARDROP		=	0x0002;			// Possibility of character drop
	Def.BT_SCAN_OCR_OUT_ALERT_TYPE_BLURRED		=	0x0004;			// Shot image is blurred
	Def.BT_SCAN_OCR_OUT_ALERT_TYPE_HALATION		=	0x0008;			// Halation detection

	Def.BT_SCAN_OCR_CHAR_RANGE_MAX2				=	88;				// Maximum character length (for passport reading)
	Def.BT_SCAN_OCR_PASSPORT_STATE_MAXLEN		=	3;				// Issuing State : string length (three-letter code)
	Def.BT_SCAN_OCR_PASSPORT_NAME_MAXLEN		=	39;				// Name of the holder : string length
	Def.BT_SCAN_OCR_PASSPORT_DOCNUM_MAXLEN		=	9;				// Document number : string length
	Def.BT_SCAN_OCR_PASSPORT_NATIONAL_MAXLEN	=	3;				// Nationality of the holder : string length (three-letter code)
	Def.BT_SCAN_OCR_PASSPORT_OPTION_MAXLEN		=	19;				// Optional data : string length
	// Sex type (BT_SCAN_OCR_REPORT_PASSPORT)
	Def.BT_SCAN_OCR_PASSPORT_SEX_FEMALE			=	1;				// Female
	Def.BT_SCAN_OCR_PASSPORT_SEX_MALE			=	2;				// Male
	Def.BT_SCAN_OCR_PASSPORT_SEX_UNSPECIFIED	=	3;				// Unspecified

	// [OCR] 7-segment character string reading mode
	Def.BT_SCAN_OCR_7SEG_MODE_OFF				=	0;				// Disable 7-segment reading
	Def.BT_SCAN_OCR_7SEG_MODE_1					=	1;				// Enable 7-segment reading
	Def.BT_SCAN_OCR_7SEG_MODE_2					=	2;				// Enable 7-segment reading(Long-term light exposure)

	// [OCR] Excluded character specification
	Def.BT_SCAN_OCR_MAX_OUT_FMT_KEYWORD_COUNT	=	50;				// Number of excluded character settings
	Def.BT_SCAN_OCR_MAX_OUT_FMT_KEYWORD_LENGTH	=	10;				// Excluded character string length

	// [OCR] Reading range
	Def.BT_SCAN_OCR_CUTOUT_LINE					=	1;				// Read above line
	Def.BT_SCAN_OCR_CUTOUT_AREA					=	2;				// Read within area
	Def.BT_SCAN_OCR_CUTOUT_AREA_LARGE			=	3;				// Read within area(large)

	// [OCR] Detection mode
	Def.BT_SCAN_OCR_DETECTION_CONNECTION		=	1;				// Connection
	Def.BT_SCAN_OCR_DETECTION_CUTTING			=	2;				// Cutting
	Def.BT_SCAN_OCR_DETECTION_AUTO				=	3;				// Auto

	// [OCR] Batch reading of multiple character strings
	Def.BT_SCAN_OCR_MULTI_STR_MAX				=	4;				// Maximum number of character strings

	// [OCR] Character order within the string
	Def.BT_SCAN_OCR_MULTI_STR_AUTO				=	0;				// Automatic distinction
	Def.BT_SCAN_OCR_MULTI_STR_VERTICAL			=	1;				// Vertical direction
	Def.BT_SCAN_OCR_MULTI_STR_HORIZONTAL		=	2;				// Horizontal direction
	Def.BT_SCAN_OCR_MULTI_STR_HORIZONTAL_INVERSE=	3;				// Horizontal direction (white and black mixture)

	// [OCR] Automatic distinction of date format
	Def.BT_SCAN_OCR_DATE_CHOICE_INFO_MAX		=	3;				// Maximum number of date selection candidates

	// Scan Result
	Def.WP_SCN_SUCCESS                          =   0; 			    // Scan success
	Def.WP_SCN_SCAN_TIMEOUT                     =   1;		        // Scan timeout
	Def.WP_SCN_DECODE_TIMEOUT                   =   2;              // Decode timeout
	Def.WP_SCN_CANCEL                           =   3;              // Canceled


	//====================================================================
	// Communication control
	//====================================================================

	// Wireless LAN status
	Def.BT_WLAN_STS_DISABLE						=	0;				// Disabled
	Def.BT_WLAN_STS_CONNECTED					=	1;				// Connected between a particular network
	Def.BT_WLAN_STS_LINKLOST					=	2;				// No service
	Def.BT_WLAN_STS_PROCESSING					=	3;				// Under trying connect between a particular network
	Def.BT_WLAN_STS_DISCONNECTED				=	4;				// Disconnected
	Def.BT_WLAN_STS_ADHOC_WAITING				=	5;				// Standby at Adhoc (beacon owner)

	// Radio signal level type
	Def.BT_WLAN_TYPE_RSSI						=	1;				// RSSI
	Def.BT_WLAN_TYPE_SNR						=	2;				// SNR

	// Wireless LAN property
	// 802.11 Physical Standards pattern
	Def.BT_WLAN_PHY_PATTERN_11B					=	0;				// 802.11b
	Def.BT_WLAN_PHY_PATTERN_11BG				=	1;				// 802.11b/g
	Def.BT_WLAN_PHY_PATTERN_11BGN				=	2;				// 802.11b/g/n
	Def.BT_WLAN_PHY_PATTERN_11A					=	3;				// 802.11a
	Def.BT_WLAN_PHY_PATTERN_11AN				=	4;				// 802.11a/n
	Def.BT_WLAN_PHY_PATTERN_11ABG				=	5;				// 802.11a/b/g
	Def.BT_WLAN_PHY_PATTERN_11ABGN				=	6;				// 802.11a/b/g/n

	// Wireless LAN connection mode
	Def.BT_WLAN_BSS_INFRASTRUCTURE				=	1;				// Infrastructure
	Def.BT_WLAN_BSS_ADHOC						=	2;				// Adhoc

	// Scan channel (2.4GHz)
	Def.BT_WLAN_SCANCHANNEL_CH1					=	0x00000001;
	Def.BT_WLAN_SCANCHANNEL_CH2					=	0x00000002;
	Def.BT_WLAN_SCANCHANNEL_CH3					=	0x00000004;
	Def.BT_WLAN_SCANCHANNEL_CH4					=	0x00000008;
	Def.BT_WLAN_SCANCHANNEL_CH5					=	0x00000010;
	Def.BT_WLAN_SCANCHANNEL_CH6					=	0x00000020;
	Def.BT_WLAN_SCANCHANNEL_CH7					=	0x00000040;
	Def.BT_WLAN_SCANCHANNEL_CH8					=	0x00000080;
	Def.BT_WLAN_SCANCHANNEL_CH9					=	0x00000100;
	Def.BT_WLAN_SCANCHANNEL_CH10				=	0x00000200;
	Def.BT_WLAN_SCANCHANNEL_CH11				=	0x00000400;
	Def.BT_WLAN_SCANCHANNEL_CH12				=	0x00000800;
	Def.BT_WLAN_SCANCHANNEL_CH13				=	0x00001000;
	Def.BT_WLAN_SCANCHANNEL_CH14				=	0x00002000;
	Def.BT_WLAN_SCANCHANNEL_2_4GHZ_ALL			=	0x00003FFF;

	// Scan channel (5GHz)
	Def.BT_WLAN_SCANCHANNEL_CH36				=	0x00000001;
	Def.BT_WLAN_SCANCHANNEL_CH40				=	0x00000002;
	Def.BT_WLAN_SCANCHANNEL_CH44				=	0x00000004;
	Def.BT_WLAN_SCANCHANNEL_CH48				=	0x00000008;
	Def.BT_WLAN_SCANCHANNEL_CH52				=	0x00000010;
	Def.BT_WLAN_SCANCHANNEL_CH56				=	0x00000020;
	Def.BT_WLAN_SCANCHANNEL_CH60				=	0x00000040;
	Def.BT_WLAN_SCANCHANNEL_CH64				=	0x00000080;
	Def.BT_WLAN_SCANCHANNEL_CH100				=	0x00000100;
	Def.BT_WLAN_SCANCHANNEL_CH104				=	0x00000200;
	Def.BT_WLAN_SCANCHANNEL_CH108				=	0x00000400;
	Def.BT_WLAN_SCANCHANNEL_CH112				=	0x00000800;
	Def.BT_WLAN_SCANCHANNEL_CH116				=	0x00001000;
	Def.BT_WLAN_SCANCHANNEL_CH120				=	0x00002000;
	Def.BT_WLAN_SCANCHANNEL_CH124				=	0x00004000;
	Def.BT_WLAN_SCANCHANNEL_CH128				=	0x00008000;
	Def.BT_WLAN_SCANCHANNEL_CH132				=	0x00010000;
	Def.BT_WLAN_SCANCHANNEL_CH136				=	0x00020000;
	Def.BT_WLAN_SCANCHANNEL_CH140				=	0x00040000;
	Def.BT_WLAN_SCANCHANNEL_W52					=	0x0000000F;	// 36,40,44,48ch (Outdoor NG)
	Def.BT_WLAN_SCANCHANNEL_W53					=	0x000000F0;	// 52,56,60,64ch (Outdoor NG)
	Def.BT_WLAN_SCANCHANNEL_W56					=	0x0007FF00;	// 100,104,108,112,116,120,124,128,132,136,140ch (Outdoor OK)
	Def.BT_WLAN_SCANCHANNEL_5GHZ_ALL			=	0x0007FFFF;

	// Adhoc communication mode
	Def.BT_WLAN_ADHOC_MODE_JOIN					=	0;				// join
	Def.BT_WLAN_ADHOC_MODE_OWNER				=	1;				// owner
	Def.BT_WLAN_ADHOC_MODE_AUTO					=	2;				// auto

	// Adhoc beacon transmission channel (at beacon owner)
	Def.BT_WLAN_ADHOC_BO_CH1					=	1;				// 2.4GHz
	Def.BT_WLAN_ADHOC_BO_CH2					=	2;
	Def.BT_WLAN_ADHOC_BO_CH3					=	3;
	Def.BT_WLAN_ADHOC_BO_CH4					=	4;
	Def.BT_WLAN_ADHOC_BO_CH5					=	5;
	Def.BT_WLAN_ADHOC_BO_CH6					=	6;
	Def.BT_WLAN_ADHOC_BO_CH7					=	7;
	Def.BT_WLAN_ADHOC_BO_CH8					=	8;
	Def.BT_WLAN_ADHOC_BO_CH9					=	9;
	Def.BT_WLAN_ADHOC_BO_CH10					=	10;
	Def.BT_WLAN_ADHOC_BO_CH11					=	11;
	Def.BT_WLAN_ADHOC_BO_CH12					=	12;
	Def.BT_WLAN_ADHOC_BO_CH13					=	13;
	Def.BT_WLAN_ADHOC_BO_CH14					=	14;

	// Wireless LAN encryption mode
	Def.BT_WLAN_ENC_NONE						=	0;				// Invalid
	Def.BT_WLAN_ENC_WEP							=	1;				// WEP
	Def.BT_WLAN_ENC_TKIP						=	2;				// TKIP
	Def.BT_WLAN_ENC_AES							=	3;				// AES

	// Wireless LAN authentication method
	Def.BT_WLAN_AUTH_OPEN						=	1;				// OPEN
	Def.BT_WLAN_AUTH_SHARED						=	2;				// SHARED
	Def.BT_WLAN_AUTH_WPA_PSK					=	3;				// WPA-PSK
	Def.BT_WLAN_AUTH_WPA2_PSK					=	4;				// WPA2-PSK
	Def.BT_WLAN_AUTH_WPA_EAP_TLS				=	5;				// WPA +EAP-TLS
	Def.BT_WLAN_AUTH_WPA2_EAP_TLS				=	6;				// WPA2+EAP-TLS
	Def.BT_WLAN_AUTH_WPA_EAP_PEAP				=	7;				// WPA +EAP-PEAP
	Def.BT_WLAN_AUTH_WPA2_EAP_PEAP				=	8;				// WPA2+EAP-PEAP

	// Wireless LAN open mode
	Def.BT_WLAN_OPEN_SYNC						=	1;				// Synchronization
	Def.BT_WLAN_OPEN_ASYNC						=	2;				// Asynchronous

	// String maximum size
	Def.BT_WLAN_SSID_MAXLEN						=	32;				// SSID
	Def.BT_WLAN_WEPKEY_MAXLEN					=	26;				// WEP-KEY
	Def.BT_WLAN_WPAKEY_MAXLEN					=	64;				// WAP(2)-KEY

	Def.MAX_PATH								=	260;			// MAX_PATH
	Def.BT_WLAN_EAP_USERNAME_MAXLEN				=	32;				// EAP authentication: User name
	Def.BT_WLAN_EAP_DOMAIN_MAXLEN				=	63;				// EAP authentication: Domain name
	Def.BT_WLAN_EAP_PASSWORD_MAXLEN				=	32;				// EAP authentication: Password
	Def.BT_WLAN_EAP_CLIENT_CERT_MAXLEN			=	Def.MAX_PATH;	// EAP client certificate

	// Wireless LAN property ID
	Def.BT_WLAN_PROP_PHY_TYPE					=	1;				// 802.11 Physical Standards
	Def.BT_WLAN_PROP_SSID_INFRA					=	2;				// SSID (Infrastructure)
	Def.BT_WLAN_PROP_SSID_ADHOC					=	3;				// SSID (Adhoc)

	Def.BT_WLAN_PROP_NETMODE					=	100;			// Wireless LAN connection mode
	Def.BT_WLAN_PROP_SCAN_TIMEOUT				=	102;			// Scan timeout (per channel)
	Def.BT_WLAN_PROP_CHANNEL_2_4GHZ				=	103;			// Scan channel (2.4GHz)
	Def.BT_WLAN_PROP_CHANNEL_5GHZ				=	104;			// Scan channel (5GHz)
	Def.BT_WLAN_PROP_ADHOC_MODE					=	200;			// Adhoc communication mode
	Def.BT_WLAN_PROP_ADHOC_BO_CHANNEL			=	201;			// Adhoc beacon transmission channel (at beacon owner)
	Def.BT_WLAN_PROP_ENCRYPTION_INFRA			=	300;			// Encryption mode
	Def.BT_WLAN_PROP_ENCRYPTION_ADHOC			=	301;			// Encryption mode
	Def.BT_WLAN_PROP_AUTHENTICATION_INFRA		=	302;			// Authentication mode
	Def.BT_WLAN_PROP_AUTHENTICATION_ADHOC		=	303;			// Authentication mode
	Def.BT_WLAN_PROP_WEP_KEY1					=	304;			// WEP key No.1 (Infrastructure)
	Def.BT_WLAN_PROP_WEP_KEY2					=	305;			// WEP key No.2 (Infrastructure)
	Def.BT_WLAN_PROP_WEP_KEY3					=	306;			// WEP key No.3 (Infrastructure)
	Def.BT_WLAN_PROP_WEP_KEY4					=	307;			// WEP key No.4 (Infrastructure)
	Def.BT_WLAN_PROP_WEP_KEY_ADHOC				=	308;			// WEP key (Adhoc)
	Def.BT_WLAN_PROP_WEP_KEYINDEX_INFRA			=	309;			// WEP key index (Infrastructure)
	Def.BT_WLAN_PROP_WEP_KEYINDEX_ADHOC			=	310;			// WEP key index (Adhoc)
	Def.BT_WLAN_PROP_PSK_KEY					=	311;			// PSK key strings
	Def.BT_WLAN_PROP_SERVER_AUTH_TIMEOUT		=	400;			// Standby time of server authenticate
	Def.BT_WLAN_PROP_EAP_USERNAME				=	401;			// EAP authentication: User name
	Def.BT_WLAN_PROP_EAP_PASSWORD				=	402;			// EAP authentication: Password
	Def.BT_WLAN_PROP_EAP_CLIENT_CERTIFICATION	=	403;			// EAP client certificate
	Def.BT_WLAN_PROP_OPENMODE					=	500;			// Wireless LAN open mode
	Def.BT_WLAN_PROP_DHCP_CONN_TIMEOUT			=	501;			// Wireless LAN DHCP connection timeout


	//-----------------------------------------
	// Class definitions
	//-----------------------------------------

	//====================================================================
	// System control
	//====================================================================
	// Terminal information

	// SysVersion class
	// Version information
	Def.SysVersion = function(_version){
		this.version = _version;
	};

	// SysHandyParam class
	// Terminal parameter
	Def.SysHandyParam = function(_value){
		this.value = _value;
	};

	// Device control

	// SysMode class
	// Mode status
	Def.SysMode = function(_mode){
		this.mode = _mode;
	};

	// SysBatteryLevel class
	// Battery level (main/sub)
	Def.SysBatteryLevel = function(_level){
		this.level = _level;
	};

	// SysEnbale class
	// Enable/Disable
	Def.SysEnable = function(_enable){
		this.enable = _enable;
	};

	// SysKeySense class
	// Physical key in the current depressed
	Def.SysKeySense = function(_pkey){
		this.pkey = _pkey;
	};

	// SysDetect class
	// SD Card insert status
	Def.SysDetect = function(_detect){
		this.detect = _detect;
	};

	// Buzzer control parameters class
	Def.BT_BUZZER_PARAM = function(_on,_off,_count,_tone,_volume){
		this.on = _on;					// ON period[ms] (1-5000)
		this.off = _off;				// OFF period[ms] (0-5000)
		this.count = _count;			// Repeat count[times] (0-100)
		this.tone = _tone;				// Tone (1(Low) - 16(High))
		this.volume = _volume;			// Volume (1(Low) - 3(High))
	};

	// Vibrator control parameters class
	Def.BT_VIBRATOR_PARAM = function(_on,_off,_count){
		this.on = _on;					// ON period[ms] (1-5000)
		this.off = _off;				// OFF period[ms] (0-5000)
		this.count = _count;			// Repeat count[times] (0-100)
	};
	
	// LED control parameters class
	Def.BT_LED_PARAM = function(_on,_off,_count,_color){
		this.on = _on;					// ON period[ms] (1-5000)
		this.off = _off;				// OFF period[ms] (0-5000)
		this.count = _count;			// Repeat count[times] (0-100)
		this.color = _color;			// Color(Red/Green/Yellow/Blue/Cyan/Magenta/White)
	};

	// Display processing

	// SysOnoff class
	// SIP display
	Def.SysOnoff = function(_onoff){
		this.onoff = _onoff;
	};

	// SysSipPanelName class
	// SIP panel name
	Def.SysSipPanelName = function(_name){
		this.name = _name;
	};

	//====================================================================
	// Scan control
	//====================================================================
	
	// Code reading conditions / parameter class
	
	// JAN code information class
	Def.BT_CODESET_JAN = function(_flgset,_adgap_max,_adgap_min){
		this.flgset = _flgset;					// Read Options
		this.adgap_max = _adgap_max;			// Maximum add-on gap
		this.adgap_min = _adgap_min;			// Minimum add-on gap
	};
	
	// Code39 code information class
	Def.BT_CODESET_C39 = function(_min,_max,_flgset,_rsv1){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Read Options
		this.rsv1 = _rsv1;						// Reserved
	};
	
	// Code128 code information class
	Def.BT_CODESET_C128 = function(_min,_max,_flgset,_rsv1){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Read Options
		this.rsv1 = _rsv1;						// Reserved
	};
	
	// GS1-128 code information class
	Def.BT_CODESET_GS128 = function(_min,_max,_flgset,_separator,_rsv){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Read Options
		this.separator = _separator;			// Character code of separator
		this.rsv = _rsv;						// Reserved
	};
	
	// NW7 code information class
	Def.BT_CODESET_NW7 = function(_min,_max,_flgset,_rsv1){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Read Options
		this.rsv1 = _rsv1;						// Reserved
	};
	
	// ITF code information class
	Def.BT_CODESET_ITF = function(_min,_max,_flgset,_rsv1){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Read Options
		this.rsv1 = _rsv1;						// Reserved
	};
	
	// Code93 code information class
	Def.BT_CODESET_C93 = function(_min,_max,_flgset,_rsv1){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Read Options
		this.rsv1 = _rsv1;						// Reserved
	};
	
	// TOF code information class
	Def.BT_CODESET_TOF = function(_min,_max){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
	};
	
	// COOP code information class
	Def.BT_CODESET_COOP = function(_min,_max){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
	};
	
	// GS1 DataBar code information class
	Def.BT_CODESET_GSD = function(_min,_max,_flgset){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Flag set
	};

	// QR code information class
	Def.BT_CODESET_QR = function(_min,_max,_flgset){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Flag set
	};
	
	// PDF417 code information class
	Def.BT_CODESET_PDF = function(_min,_max,_flgset){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Flag set
	};
	
	// DataMatrix code information class
	Def.BT_CODESET_DM = function(_min,_max,_flgset){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Flag set
	};

	// MaxiCode code information class
	Def.BT_CODESET_MC = function(_min,_max,_flgset){
		this.min = _min;						// Minimum number of digits
		this.max = _max;						// Maximum number of digits
		this.flgset = _flgset;					// Flag set
	};

	// Composite code information class
	Def.BT_CODESET_COMPOSITE = function(_flgset,_separator,_rsv){
		this.flgset = _flgset;					// Flag set
		this.separator = _separator;			// Character code of separator
		this.rsv = _rsv;						// Reserved
	};

	// Multi code settings class
	Def.BT_SCAN_FD_SET_PARAM = function(_min01,_min02,_min03,_min04,_min05,_min06,_min07,_min08,_min09,_min10,_min11,_min12,_min13,_min14,_min15,_min16,_max01,_max02,_max03,_max04,_max05,_max06,_max07,_max08,_max09,_max10,_max11,_max12,_max13,_max14,_max15,_max16,_type01,_type02,_type03,_type04,_codecount01,_codecount02,_codecount03,_codecount04,_typecount,_rsv1){
		//Column structure
		this.min01 = _min01;					// Limit minimum number of digits[0][0]
		this.min02 = _min02;					// Limit minimum number of digits[0][1]
		this.min03 = _min03;					// Limit minimum number of digits[0][2]
		this.min04 = _min04;					// Limit minimum number of digits[0][3]
		this.min05 = _min05;					// Limit minimum number of digits[1][0]
		this.min06 = _min06;					// Limit minimum number of digits[1][1]
		this.min07 = _min07;					// Limit minimum number of digits[1][2]
		this.min08 = _min08;					// Limit minimum number of digits[1][3]
		this.min09 = _min09;					// Limit minimum number of digits[2][0]
		this.min10 = _min10;					// Limit minimum number of digits[2][1]
		this.min11 = _min11;					// Limit minimum number of digits[2][2]
		this.min12 = _min12;					// Limit minimum number of digits[2][3]
		this.min13 = _min13;					// Limit minimum number of digits[3][0]
		this.min14 = _min14;					// Limit minimum number of digits[3][1]
		this.min15 = _min15;					// Limit minimum number of digits[3][2]
		this.min16 = _min16;					// Limit minimum number of digits[3][3]
		this.max01 = _max01;					// Limit maximum number of digits[0][0]
		this.max02 = _max02;					// Limit maximum number of digits[0][1]
		this.max03 = _max03;					// Limit maximum number of digits[0][2]
		this.max04 = _max04;					// Limit maximum number of digits[0][3]
		this.max05 = _max05;					// Limit maximum number of digits[1][0]
		this.max06 = _max06;					// Limit maximum number of digits[1][1]
		this.max07 = _max07;					// Limit maximum number of digits[1][2]
		this.max08 = _max08;					// Limit maximum number of digits[1][3]
		this.max09 = _max09;					// Limit maximum number of digits[2][0]
		this.max10 = _max10;					// Limit maximum number of digits[2][1]
		this.max11 = _max11;					// Limit maximum number of digits[2][2]
		this.max12 = _max12;					// Limit maximum number of digits[2][3]
		this.max13 = _max13;					// Limit maximum number of digits[3][0]
		this.max14 = _max14;					// Limit maximum number of digits[3][1]
		this.max15 = _max15;					// Limit maximum number of digits[3][2]
		this.max16 = _max16;					// Limit maximum number of digits[3][3]
		//Codeset structure
		this.type01 = _type01;					// Code type: position[0]
		this.type02 = _type02;					// Code type: position[1]
		this.type03 = _type03;					// Code type: position[2]
		this.type04 = _type04;					// Code type: position[3]
		this.codecount01 = _codecount01;		// Number of codes to be compared: position[0]
		this.codecount02 = _codecount02;		// Number of codes to be compared: position[1]
		this.codecount03 = _codecount03;		// Number of codes to be compared: position[2]
		this.codecount04 = _codecount04;		// Number of codes to be compared: position[3]
		//Set structure
		this.typecountt = _typecount;			// Number of columns valid
		this.rsv1 = _rsv1;						// Reserved
	};

	// ScanProperty class
	// * for getting info except structure at btScanGetProperty
	Def.ScanProperty = function(_prop){
		this.prop = _prop;
	};

	// Other
	// ScanDataCodeData class
	// Scan strings
	Def.ScanDataCodeData = function(_codedata){
		this.codedata = _codedata;
	};

	// ScanReport class
	// Read results report
	Def.BT_SCAN_REPORT = function(_keta,_codetype,_composite,_quality,_extratype,_codelink){
		this.keta = _keta;						// Number of digits
		this.codetype = _codetype;				// code type
		this.composite = _composite;			// Composite?
		this.quality = _quality;				// Scanning quality
		this.extratype = _extratype;			// Detail information of code type
		this.codelink = _codelink;				// Use barcode link function?
	};	

	// QrReport class
	// Read results report (QR code)
	Def.BT_SCAN_QR_REPORT = function(_pos,_parity,_count){
		this.pos = _pos;						// Position of read results
		this.parity = _parity;					// Parity
		this.count = _count;					// Total connectivity number
	};

	// ScanStringCodeData class
	// Scan strings
	Def.ScanStringCodeData = function(_codedata){
		this.codedata = _codedata;
	};

	// ScanStringSymbol class
	// Code type
	Def.ScanStringSymbol = function(_symbol){
		this.symbol = _symbol;
	};

	// Brightness of external illumination
	Def.BT_SCAN_EXT_LIGHT_BRIGHTNESS = function( _nolight, _normal, _multi, _low, _3D, _area ){
		this.BrightnessNolight	= _nolight;		// No lighting 
		this.BrightnessNormal	= _normal;		// Internal lighting
		this.BrightnessMulti	= _multi;		// Multi-angle lighting
		this.BrightnessLow		= _low;			// Low angle lighting
		this.Brightness3D		= _3D;			// (Reserved) 3D character reading lighting
		this.Area				= _area;		// Target area 
	};

	// [OCR] Range restriction class
	Def.BT_SCAN_OCR_SIMPLE_FORMAT = function(_valid,_CharType,_CharRangeMin,_CharRangeMax,_LMargin,_RMargin){
		this.valid = _valid;					// Enable setting (0: disable, 1:enable)
		this.CharType = _CharType;				// Character type (BT_SCAN_OCR_CHARTYPE_XXX)
		this.CharRangeMin = _CharRangeMin;		// Minimum character digit range (BT_SCAN_OCR_CHAR_RANGE_XXX)
		this.CharRangeMax = _CharRangeMax;		// Maximum character digit range (BT_SCAN_OCR_CHAR_RANGE_XXX)
		this.LMargin = _LMargin;				// Margin: Left (0: disable, 1:enable)
		this.RMargin = _RMargin;				// Margin: Right (0: disable, 1:enable)
	};

	// [OCR] Format registration
	Def.BT_SCAN_OCR_FORMAT_EACH = function(_CharMode,_digits,_alphabets,_marks,_reserve){
		this.CharMode = _CharMode;				// Format registration number
		this.digits = _digits;					// Enable setting (0: disable, 1:enable)
		this.alphabets = _alphabets;			// Number of character (BT_SCAN_OCR_CHAR_RANGE_MIN ~ MAX)
		this.marks = _marks;					// Margin: Left (0: disable, 1:enable)
		this.reserve = _reserve;				// Margin: Right (0: disable, 1:enable)
	};

	Def.BT_SCAN_OCR_DETAIL_FORMAT = function(_FormatNumber,_valid,_CharLen,_LMargin,_RMargin){
		this.FormatNumber = _FormatNumber;		// Format registration number (BT_SCAN_OCR_DFMT_BANK_MIN ~ MAX)
		this.valid = _valid;					// Enable setting (0: disable, 1:enable)
		this.CharLen = _CharLen;				// Number of character (BT_SCAN_OCR_CHAR_RANGE_MIN ~ MAX)
		this.LMargin = _LMargin;				// Margin: Left (0: disable, 1:enable)
		this.RMargin = _RMargin;				// Margin: Right (0: disable, 1:enable)
	};

	// [OCR] Read Japanese calendar class
	Def.BT_SCAN_OCR_ERA = function(_valid1,_FirstYear1,_RangeMin1,_RangeMax1,_valid2,_FirstYear2,_RangeMin2,_RangeMax2){
		this.valid1 = _valid1;					// SET1: Enable setting (0: disable, 1:enable)
		this.FirstYear1 = _FirstYear1;			// SET1: Character type (BT_SCAN_OCR_CHARTYPE_XXX)
		this.RangeMin1 = _RangeMin1;			// SET1: Minimum character digit range (BT_SCAN_OCR_CHAR_RANGE_XXX)
		this.RangeMax1 = _RangeMax1;			// SET1: Maximum character digit range (BT_SCAN_OCR_CHAR_RANGE_XXX)
		this.valid2 = _valid2;					// SET2: Enable setting (0: disable, 1:enable)
		this.FirstYear2 = _FirstYear2;			// SET2: Character type (BT_SCAN_OCR_CHARTYPE_XXX)
		this.RangeMin2 = _RangeMin2;			// SET2: Minimum character digit range (BT_SCAN_OCR_CHAR_RANGE_XXX)
		this.RangeMax2 = _RangeMax2;			// SET2: Maximum character digit range (BT_SCAN_OCR_CHAR_RANGE_XXX)
	};

	// [OCR] Date recognition range class
	Def.BT_SCAN_OCR_RECOG_DATE = function(_yearStart,_monthStart,_dayStart,_yearEnd,_monthEnd,_dayEnd){
		this.yearStart = _yearStart;			// START: Year (A.D.)
		this.monthStart = _monthStart;			// START: Month
		this.dayStart = _dayStart;				// START: Day
		this.yearEnd = _yearEnd;				// END: Year (A.D.)
		this.monthEnd = _monthEnd;				// END: Month
		this.dayEnd = _dayEnd;					// END: Day
	};

	// [OCR] Result information class
	Def.BT_SCAN_OCR_REPORT = function(_DataFormat,_AlertType,_FormatNumber,_SourceDataLen,_SourceData){
		this.DataFormat = _DataFormat;			// OCR recognition pattern (BT_SCAN_OCR_RPATTERN_XXX)
		this.AlertType = _AlertType;			// Alert information (BT_SCAN_OCR_OUT_ALERT_TYPE_XXX)
		this.FormatNumber = _FormatNumber;		// Format registration number of recognition (-3:Passport reading, -2:Date recognition, -1:Range restriction, BT_SCAN_OCR_DFMT_BANK_MIN ~ BT_SCAN_OCR_DFMT_BANK_MAX:Format registration)
		this.SourceDataLen = _SourceDataLen;	// Number of recognized characters
		this.SourceData = _SourceData;			// Recognized characters
	};

	// [OCR] ScanOcrAttention class
	Def.ScanOcrAttention = function(_value){
		this.value = _value;
	};

	// [OCR] Result information class (passport)
	Def.BT_SCAN_OCR_REPORT_PASSPORT = function(_discretionOfIssuingState, _issuingState, _fullName, _nameTruncated, _passportNumber, _nationality, _yearOfBirth, _monthOfBirth, _dayOfBirth, _sex, _yearOfExpiry, _monthOfExpiry, _dayOfExpiry, _optionalData){
		this.discretionOfIssuingState = _discretionOfIssuingState;
		this.issuingState = _issuingState;
		this.fullName = _fullName;
		this.nameTruncated = _nameTruncated;
		this.passportNumber = _passportNumber;
		this.nationality = _nationality;
		this.yearOfBirth = _yearOfBirth;
		this.monthOfBirth = _monthOfBirth;
		this.dayOfBirth = _dayOfBirth;
		this.sex = _sex;
		this.yearOfExpiry = _yearOfExpiry;
		this.monthOfExpiry = _monthOfExpiry;
		this.dayOfExpiry = _dayOfExpiry;
		this.optionalData = _optionalData;
	};

	// [OCR] Result information class (multiple character strings)
	Def.BT_SCAN_OCR_REPORT_MULTI_STR = function(_DataFormat1, _DataFormat2, _DataFormat3, _DataFormat4, _FormatNumber1, _FormatNumber2, _FormatNumber3, _FormatNumber4, _SourceDataLen1, _SourceDataLen2, _SourceDataLen3, _SourceDataLen4, _SourceData1, _SourceData2, _SourceData3, _SourceData4, _FormattedDataLen1, _FormattedDataLen2, _FormattedDataLen3, _FormattedDataLen4, _FormattedData1, _FormattedData2, _FormattedData3, _FormattedData4, _StringCount, _AlertType){
		this.DataFormat1 = _DataFormat1;				// OCR recognition pattern 1 (BT_SCAN_OCR_RPATTERN_XXX)
		this.DataFormat2 = _DataFormat2;				// OCR recognition pattern 2 (BT_SCAN_OCR_RPATTERN_XXX)
		this.DataFormat3 = _DataFormat3;				// OCR recognition pattern 3 (BT_SCAN_OCR_RPATTERN_XXX)
		this.DataFormat4 = _DataFormat4;				// OCR recognition pattern 4 (BT_SCAN_OCR_RPATTERN_XXX)
		this.FormatNumber1 = _FormatNumber1;			// Format registration number of recognition 1 (-2:Date recognition, -1:Range restriction, 1~50:Format registration)
		this.FormatNumber2 = _FormatNumber2;			// Format registration number of recognition 2 (-2:Date recognition, -1:Range restriction, 1~50:Format registration)
		this.FormatNumber3 = _FormatNumber3;			// Format registration number of recognition 3 (-2:Date recognition, -1:Range restriction, 1~50:Format registration)
		this.FormatNumber4 = _FormatNumber4;			// Format registration number of recognition 4 (-2:Date recognition, -1:Range restriction, 1~50:Format registration)
		this.SourceDataLen1 = _SourceDataLen1;			// Number of recognized characters 1
		this.SourceDataLen2 = _SourceDataLen2;			// Number of recognized characters 2
		this.SourceDataLen3 = _SourceDataLen3;			// Number of recognized characters 3
		this.SourceDataLen4 = _SourceDataLen4;			// Number of recognized characters 4
		this.SourceData1 = _SourceData1;				// Recognized characters 1
		this.SourceData2 = _SourceData2;				// Recognized characters 2
		this.SourceData3 = _SourceData3;				// Recognized characters 3
		this.SourceData4 = _SourceData4;				// Recognized characters 4
		this.FormattedDataLen1 = _FormattedDataLen1;	// Data length 1
		this.FormattedDataLen2 = _FormattedDataLen2;	// Data length 2
		this.FormattedDataLen3 = _FormattedDataLen3;	// Data length 3
		this.FormattedDataLen4 = _FormattedDataLen4;	// Data length 4
		this.FormattedData1 = _FormattedData1;			// Formatted data 1
		this.FormattedData2 = _FormattedData2;			// Formatted data 2
		this.FormattedData3 = _FormattedData3;			// Formatted data 3
		this.FormattedData4 = _FormattedData4;			// Formatted data 4
		this.StringCount = _StringCount;				// Number of read character strings
		this.AlertType = _AlertType;					// Alert information (BT_SCAN_OCR_OUT_ALERT_TYPE_XXX)
	};

	// [OCR] Result information class (Date selection candidate)
	Def.BT_SCAN_OCR_REPORT_DATE_CHOICE = function(_OutDateFormat, _OutDateDelim, _valid1, _valid2, _valid3, _date1, _date2, _date3, _year1, _year2, _year3, _month1, _month2, _month3, _day1, _day2, _day3){
		this.OutDateFormat = _OutDateFormat;			// Date output pattern (BT_SCAN_OCR_OUT_DATE_FORMAT_XXX)
		this.OutDateDelim = _OutDateDelim;				// Date output separator (BT_SCAN_OCR_OUT_DATE_DELIM_XXX)
		this.valid1 = _valid1;							// valid/invalid 1
		this.valid2 = _valid2;							// valid/invalid 2
		this.valid3 = _valid3;							// valid/invalid 3
		this.date1 = _date1;							// Date candidate 1 (Date string containing delimiter)
		this.date2 = _date2;							// Date candidate 2 (Date string containing delimiter)
		this.date3 = _date3;							// Date candidate 3 (Date string containing delimiter)
		this.year1 = _year1;							// Date candidate 1 (Year)
		this.year2 = _year2;							// Date candidate 2 (Year)
		this.year3 = _year3;							// Date candidate 3 (Year)
		this.month1 = _month1;							// Date candidate 1 (Month)
		this.month2 = _month2;							// Date candidate 2 (Month)
		this.month3 = _month3;							// Date candidate 3 (Month)
		this.day1 = _day1;								// Date candidate 1 (Day)
		this.day2 = _day2;								// Date candidate 2 (Day)
		this.day3 = _day3;								// Date candidate 3 (Day)
	};

	// [OCR] Keyword to exclude class
	Def.BT_SCAN_OCR_STR_OUTPUT_FMT_KEY = function(_keyword, _reserve){
		this.keyword = _keyword;				// Keyword
		this.reserve = _reserve;				// Reserved
	};

	// [OCR] Excluded character specification class
	Def.BT_SCAN_OCR_STR_OUTPUT_FMT = function(_valid, _rsv1){
		this.valid = _valid;					// Enable setting (0: disable, 1:enable)
		this.rsv1 = _rsv1; 						// Reserved (Set to 0)
	};

	// [OCR] Multiple character string setting class
	Def.BT_SCAN_OCR_MULTI_STR = function(_valid, _strcount, _position, _pattern1, _pattern2, _pattern3, _pattern4, _OutputSeparator, _separator){
		this.valid			= _valid;				// Enable setting (0: disable, 1:enable)
		this.strcount		= _strcount;			// Number of character strings
		this.position		= _position;			// Character order within the string
		this.pattern1		= _pattern1;			// OCR recognition pattern 1 (BT_SCAN_OCR_RPATTERN_XXX)
		this.pattern2		= _pattern2;			// OCR recognition pattern 2 (BT_SCAN_OCR_RPATTERN_XXX)
		this.pattern3		= _pattern3;			// OCR recognition pattern 3 (BT_SCAN_OCR_RPATTERN_XXX)
		this.pattern4		= _pattern4;			// OCR recognition pattern 4 (BT_SCAN_OCR_RPATTERN_XXX)
		this.OutputSeparator= _OutputSeparator;		// Separator output
		this.separator		= _separator;			// Character code of separator
	};

	//====================================================================
	// Communication control
	//====================================================================
	
	// Bluetooth
	
	// Bluetooth device information (target) class
	Def.BT_BLUETOOTH_TARGET = function(_name,_addr){
		this.name = _name;				// Bluetooth device name
		this.addr = _addr;				// Bluetooth device address
	};

	// CommDevCount class
	// Number of the discovered devices
	Def.CommDevCount = function(_count){
		this.count = _count;
	};

	// CommSppDataSize class
	// Data size at SPP send/receive
	Def.CommSppDataSize = function(_size){
		this.size = _size;
	};

	// CommSppRecvData class
	// Data at SPP receive
	Def.CommSppRecvData = function(_data){
		this.data = _data;
	};

	// Wireless LAN
	
	// CommMacAddress class
	// MAC address
	Def.CommMacAddress = function(_macaddr){
		this.macaddr = _macaddr;
	};

	// CommStatus class
	// status
	Def.CommStatus = function(_status){
		this.status = _status;
	};

	// CommWlanRadioLevel class
	// Radio signal level (RSSI/SNR)
	Def.CommWlanRadioLevel = function(_level){
		this.level = _level;
	};

	// CommWlanProp class
	// Wireless LAN property
	Def.CommWlanProp = function(_prop){
		this.prop = _prop;
	};

	//====================================================================
	// File control
	//====================================================================

	// FileReadData class
	// Data at file reading
	Def.FileReadData = function(_data)
	{
		this.data = _data;
	};

})();
