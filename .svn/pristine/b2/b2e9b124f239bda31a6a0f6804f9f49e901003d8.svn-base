// *******************************************************************************
// **	Copyright(c) 2012-2014 Keyence Corporation. All rights reserved
// **	File Name: btSysLib.js
// **
// **	Function	: Terminal Library JavaScript File (System control)
// **	Notes		: None
// **
// ********************************************************************************

//Create Namespace
var Bt;
if( !Bt ){
	Bt = {};							// Namespace "Bt"
}
if( !Bt.SysLib ){
	Bt.SysLib = {};						// Namespace "Bt.SysLib"
}
if( !Bt.SysLib.Terminal ){
	Bt.SysLib.Terminal = {};			// Namespace "Bt.SysLib.Terminal"
}
if( !Bt.SysLib.Device ){
	Bt.SysLib.Device = {};				// Namespace "Bt.SysLib.Device"
}
if( !Bt.SysLib.Power ){
	Bt.SysLib.Power = {};				// Namespace "Bt.SysLib.Power"
}
if( !Bt.SysLib.Display ){
	Bt.SysLib.Display = {};				// Namespace "Bt.SysLib.Display"
}
if( !Bt.SysLib.Utility ){
	Bt.SysLib.Utility = {};				// Namespace "Bt.SysLib.Utility"
}

//Functions in Namespace

(function() {

	var SysLib = Bt.SysLib;

	//------------------------------------------------------------------------
	// Bt.SysLib.Terminal
	//------------------------------------------------------------------------
	//*********************************************************************************
	// * @brief	Function:@n	[Get system software version]
	// * @n
	// * @param	[out]	objOS	:Terminal OS version (SysVersion class)
	// * @param	[out]	objBL	:Boot Loader version (SysVersion class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Terminal.btGetSysVersion = function( objOS, objBL )
	{
		var ret = btSysLib_X.btGetSysVersion();		// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			objOS.version = btSysLib_X.OsVersion;		// Get Terminal OS version
			objBL.version = btSysLib_X.BootVersion;		// Get Boot Loader version
		}
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Get terminal parameter]
	// * @n
	// * @param	[in]	id		:Terminal parameter type
	// * @param	[out]	obj		:Settings buffer (SysHandyParam class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Terminal.btGetHandyParameter = function( id, obj )
	{
		var ret = btSysLib_X.btGetHandyParameter( id );	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			// Get property
			switch(id)
			{
				case Bt.LibDef.BT_SYS_PRM_HTTYPE:					// Model
					obj.value = btSysLib_X.HandyParamHtType;
					break;
				case Bt.LibDef.BT_SYS_PRM_HTNAME:					// Terminal name
					obj.value = btSysLib_X.HandyParamHtName;
					break;
				case Bt.LibDef.BT_SYS_PRM_GROUPNAME:				// Group name
					obj.value = btSysLib_X.HandyParamGroupName;
					break;		
				case Bt.LibDef.BT_SYS_PRM_SERIALNO:				// Serial number
					obj.value = btSysLib_X.HandyParamSerialNo;
					break;
				default:
					break;
			}
		}
		return ret;
	};

	//------------------------------------------------------------------------
	// Bt.SysLib.Device
	//------------------------------------------------------------------------
	//*********************************************************************************
	// * @brief	Function:@n	[Get battery level (main)]
	// * @n
	// * @param	[out]	obj		:Battery level (main) (SysBatteryLevel class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btGetMainBatteryLevel = function( obj )
	{
		var ret = btSysLib_X.btGetMainBatteryLevel();		// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.level = btSysLib_X.MainBatteryLevel;	// Get battery level (main) property
		}
		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[Buzzer control]
	// * @n
	// * @param	[in]	on		:Buzzer behavior
	// * @param	[in]	obj		:Buzzer control parameters class (BT_BUZZER_PARAM class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btBuzzer = function( on, obj )
	{
		// Set to Buzzer control property
		btSysLib_X.BuzzerOn = obj.on;				// ON period
		btSysLib_X.BuzzerOff = obj.off;				// OFF period
		btSysLib_X.BuzzerCount = obj.count;			// Repeat count
		btSysLib_X.BuzzerTone = obj.tone;			// Tone
		btSysLib_X.BuzzerVolume = obj.volume;		// Volume
		
		var ret = btSysLib_X.btBuzzer( on );		// Execute ActiveX method

		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Vibrator control]
	// * @n
	// * @param	[in]	on		:Vibrator behavior
	// * @param	[in]	obj		:Vibrator control parameters class (BT_VIBRATOR_PARAM class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btVibrator = function( on, obj )
	{
		// Set to Vibrator control property
		btSysLib_X.VibOn = obj.on;				// ON period
		btSysLib_X.VibOff = obj.off;			// OFF period
		btSysLib_X.VibCount = obj.count;		// Repeat count
		
		var ret = btSysLib_X.btVibrator( on );		// Execute ActiveX method

		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[LED control]
	// * @n
	// * @param	[in]	on		:LED behavior
	// * @param	[in]	obj		:LED control parameters class (BT_LED_PARAM class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btLED = function( on, obj )
	{
		// Set to LED control property
		btSysLib_X.LedOn = obj.on;				// ON period
		btSysLib_X.LedOff = obj.off;			// OFF period
		btSysLib_X.LedCount = obj.count;		// Repeat count
		btSysLib_X.LedColor = obj.color;		// Color
		
		var ret = btSysLib_X.btLED( on );		// Execute ActiveX method

		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Set touch panel function]
	// * @n
	// * @param	[in]	enable		:Enable/Disable touch panel
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btSetTouchpanelEnable = function( enable )
	{
		var ret = btSysLib_X.btSetTouchpanelEnable( enable );	// Execute ActiveX method
		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[Get touch panel function]
	// * @n
	// * @param	[out]	obj		:Enable/Disable touch panel (SysEnable class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btGetTouchpanelEnable = function( obj )
	{
		var ret = btSysLib_X.btGetTouchpanelEnable();	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.enable = btSysLib_X.TouchpanelEnable;	// Get Enable/Disable touch panel property
		}
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Get physical key in the current depressed]
	// * @n
	// * @param	[in]	keyval	:Target physical key
	// * @param	[out]	obj		:Physical key in the current depressed class (SysKeySense class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btKeySense = function( refkey, obj )
	{
		var ret = btSysLib_X.btKeySense( refkey );		// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			// Get property
			obj.pkey = btSysLib_X.KeySense;			// Physical key in the current depressed
		}
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Get SD Card insert status]
	// * @n
	// * @param	[out]	obj		:SD Card insert status (SysDetect class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Device.btGetSDCardDetect = function( obj )
	{
		var ret = btSysLib_X.btGetSDCardDetect();		// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			// Get SD Card insert status property
			obj.detect = btSysLib_X.SdDetect;
		}
		return ret;
	};

	//------------------------------------------------------------------------
	// Bt.SysLib.Power
	//------------------------------------------------------------------------
	//*********************************************************************************
	// * @brief	Function:@n	[Power Off Control (manual)]
	// * @n
	// * @param	[in]	mode	:Power Off mode
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Power.btManualPowerOFF = function( mode )
	{
		var ret = btSysLib_X.btManualPowerOFF( mode );		// Execute ActiveX method
		return ret;
	};

	//------------------------------------------------------------------------
	// Bt.SysLib.Display
	//------------------------------------------------------------------------
	//*********************************************************************************
	// * @brief	Function:@n	[Set SIP(Software Input Panel)]
	// * @n
	// * @param	[in]	show	:SIP ON/OFF
	// * @param	[in]	name	:SIP panel name
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Display.btSetSIP = function( show, name )
	{
		var ret = btSysLib_X.btSetSIP( show, name );	// Execute ActiveX method
		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[Get SIP(Software Input Panel)]
	// * @n
	// * @param	[out]	objOnoff	:SIP ON/OFF (SysOnoff class)
	// * @param	[out]	objName		:SIP panel name (SysSipPanelName class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Display.btGetSIP = function( objOnoff, objName )
	{
		var ret = btSysLib_X.btGetSIP();			// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			objOnoff.onoff = btSysLib_X.SipShow;	// Get SIP ON/OFF property
			objName.name = btSysLib_X.SipName;		// Get SIP panel name property
		}
		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[Set key input mode]
	// * @n
	// * @param	[in]	mode	:Key input mode
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Display.btSetKeyCharacter = function( mode )
	{
		var ret = btSysLib_X.btSetKeyCharacter( mode );		// Execute ActiveX method
		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[Get key input mode]
	// * @n
	// * @param	[out]	obj		:Key input mode (SysMode class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Display.btGetKeyCharacter = function( obj )
	{
		var ret = btSysLib_X.btGetKeyCharacter();		// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.mode = btSysLib_X.KeyCharacterMode;		// Get Key input mode property
		}
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Set mouse emulator function]
	// * @n
	// * @param	[in]	enable		:Enable/Disable mouse emulator
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Display.btSetMouseEmulatorEnable = function( enable )
	{
		var ret = btSysLib_X.btSetMouseEmulatorEnable( enable );	// Execute ActiveX method
		return ret;
	};
	
	//*********************************************************************************
	// * @brief	Function:@n	[Get mouse emulator function]
	// * @n
	// * @param	[out]	obj		:Enable/Disable mouse emulator (SysEnable class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Display.btGetMouseEmulatorEnable = function( obj )
	{
		var ret = btSysLib_X.btGetMouseEmulatorEnable();	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.enable = btSysLib_X.MouseEmuEnable;	// Get Enable/Disable mouse emulator property
		}
		return ret;
	};

	//------------------------------------------------------------------------
	// Bt.SysLib.Utility
	//------------------------------------------------------------------------
	//*********************************************************************************
	// * @brief	Function:@n	[Write accumulated log for User-defined]
	// * @n
	// * @param	[in]	id		:ID
	// * @param	[in]	value	:Incremental value
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Utility.btWriteAppCountLog = function( id, value )
	{
		var ret = btSysLib_X.btWriteAppCountLog( id, value );		// Execute ActiveX method
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Reset accumulated log for User-defined]
	// * @n
	// * @param	[in]	id	:ID
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Utility.btResetAppCountLog = function( id )
	{
		var ret = btSysLib_X.btResetAppCountLog( id );		// Execute ActiveX method
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Update using package file (*.kpg)]
	// * @n
	// * @param	[in]	path		:Package file path
	// * @param	[in]	reserved	:Reserved (should set to 0)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Utility.btSysUpdatePackage = function( path, reserved )
	{
		var ret = btSysLib_X.btSysUpdatePackage( path, reserved );		// Execute ActiveX method
		return ret;
	};

	//*********************************************************************************
	// * @brief	Function:@n	[Get activation information]
	// * @n
	// * @param	[in]	functionCode	:Function type
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	SysLib.Utility.btSysGetActivated = function( functionCode )
	{
		var ret = btSysLib_X.btSysGetActivated( functionCode );		// Execute ActiveX method
		return ret;
	};

})();

