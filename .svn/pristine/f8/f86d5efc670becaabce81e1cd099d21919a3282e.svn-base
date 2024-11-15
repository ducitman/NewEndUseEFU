// *******************************************************************************
// **	Copyright(c) 2012-2014 Keyence Corporation. All rights reserved
// **	File Name: btScanLib.js
// **
// **	Function	: Terminal Library JavaScript File (Scan control)
// **	Notes		: None
// **
// ********************************************************************************

//Create Namespace
var Bt;
if( !Bt ){
	Bt = {};							// Namespace "Bt"
}
if( !Bt.ScanLib ){
	Bt.ScanLib = {};					// Namespace "Bt.ScanLib"
}
if( !Bt.ScanLib.Control ){
	Bt.ScanLib.Control = {};			// Namespace "Bt.ScanLib.Control"
}
if( !Bt.ScanLib.Setting ){
	Bt.ScanLib.Setting = {};			// Namespace "Bt.ScanLib.Setting"
}
if( !Bt.ScanLib.Utility ){
	Bt.ScanLib.Utility = {};			// Namespace "Bt.ScanLib.Utility"
}

//Functions in Namespace
(function() {

	var ScanLib = Bt.ScanLib;
	
	//------------------------------------------------------------------------
	// Bt.ScanLib.Setting
	//------------------------------------------------------------------------
	//********************************************************************************
	// * @brief	Function:@n	[Set scan property]
	// * @n
	// * @param	[in]	id		:ID
	// * @param	[in]	obj		:Property value (ScanProperty class, or another class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanSetProperty = function( id, obj )
	{
		//Set property
		switch(id)
		{
			// obj: BT_CODESET_XXX class
			case Bt.LibDef.BT_SCAN_PROP_JAN:					// JAN property
				btScanLib_X.JanAdGap_min = obj.adgap_min;
				btScanLib_X.JanAdGap_max = obj.adgap_max;
				btScanLib_X.JanFlgset = obj.flgset;
				break;
			case Bt.LibDef.BT_SCAN_PROP_CODE39:				// Code39 property
				btScanLib_X.C39Min = obj.min;
				btScanLib_X.C39Max = obj.max;
				btScanLib_X.C39Flgset = obj.flgset;
				btScanLib_X.C39Rsv1 = obj.rsv1;
				break;
			case Bt.LibDef.BT_SCAN_PROP_CODE128:				// Code128 property
				btScanLib_X.C128Min = obj.min;
				btScanLib_X.C128Max = obj.max;
				btScanLib_X.C128Flgset = obj.flgset;
				btScanLib_X.C128Rsv1 = obj.rsv1;
				break;		
			case Bt.LibDef.BT_SCAN_PROP_GS1_128:				// GS1-128 property
				btScanLib_X.Gs128Min = obj.min;
				btScanLib_X.Gs128Max = obj.max;
				btScanLib_X.Gs128Flgset = obj.flgset;
				btScanLib_X.Gs128Separator = obj.separator;
				btScanLib_X.Gs128Rsv = obj.rsv;
				break;
			case Bt.LibDef.BT_SCAN_PROP_NW7:					// NW7 property
				btScanLib_X.Nw7Min = obj.min;
				btScanLib_X.Nw7Max = obj.max;
				btScanLib_X.Nw7Flgset = obj.flgset;
				btScanLib_X.Nw7Rsv1 = obj.rsv1;
				break;
			case Bt.LibDef.BT_SCAN_PROP_ITF:					// ITF property
				btScanLib_X.ItfMin = obj.min;
				btScanLib_X.ItfMax = obj.max;
				btScanLib_X.ItfFlgset = obj.flgset;
				btScanLib_X.ItfRsv1 = obj.rsv1;
				break;
			case Bt.LibDef.BT_SCAN_PROP_CODE93:				// Code93 property
				btScanLib_X.C93Min = obj.min;
				btScanLib_X.C93Max = obj.max;
				btScanLib_X.C93Flgset = obj.flgset;
				btScanLib_X.C93Rsv1 = obj.rsv1;
				break;
			case Bt.LibDef.BT_SCAN_PROP_TOF:					// TOF property
				btScanLib_X.TofMin = obj.min;
				btScanLib_X.TofMax = obj.max;
				break;
			case Bt.LibDef.BT_SCAN_PROP_COOP:					// COOP property
				btScanLib_X.CoopMin = obj.min;
				btScanLib_X.CoopMax = obj.max;
				break;
			case Bt.LibDef.BT_SCAN_PROP_GS1_DB:				// GS1 DataBar property
				btScanLib_X.GsdMin = v.min;
				btScanLib_X.GsdMax = obj.max;
				btScanLib_X.GsdFlgset = obj.flgset;
				break;
			case Bt.LibDef.BT_SCAN_PROP_QR:					// QR property
				btScanLib_X.QrMin = obj.min;
				btScanLib_X.QrMax = obj.max;
				btScanLib_X.QrFlgset = obj.flgset;
				break;
			case Bt.LibDef.BT_SCAN_PROP_PDF:					// PDF417 property
				btScanLib_X.PdfMin = obj.min;
				btScanLib_X.PdfMax = obj.max;
				btScanLib_X.PdfFlgset = obj.flgset;
				break;
			case Bt.LibDef.BT_SCAN_PROP_DM:					// DataMatrix property
				btScanLib_X.DmMin = obj.min;
				btScanLib_X.DmMax = obj.max;
				btScanLib_X.DmFlgset = obj.flgset;
				break;
			case Bt.LibDef.BT_SCAN_PROP_MC:					// MaxiCode property
				btScanLib_X.McMin = obj.min;
				btScanLib_X.McMax = obj.max;
				btScanLib_X.McFlgset = obj.flgset;
				break;
			case Bt.LibDef.BT_SCAN_PROP_COMPOSITE:			// Composite symbol property
				btScanLib_X.CompFlgset = obj.flgset;
				btScanLib_X.CompSeparator = obj.separator;
				btScanLib_X.CompRsv = obj.rsv;
				break;
			case Bt.LibDef.BT_SCAN_PROP_ENABLE_SYMBOLS:		// Code permitted to read
				btScanLib_X.ScanPropEnableSymbol = obj.prop;
				break;

			// obj: BT_SCAN_FD_SET_PARAM class
			case Bt.LibDef.BT_SCAN_PROP_FULLDETECTION:		// Multi code setting
				btScanLib_X.FdColumnMin01 = obj.min01;
				btScanLib_X.FdColumnMin02 = obj.min02;
				btScanLib_X.FdColumnMin03 = obj.min03;
				btScanLib_X.FdColumnMin04 = obj.min04;
				btScanLib_X.FdColumnMin05 = obj.min05;
				btScanLib_X.FdColumnMin06 = obj.min06;
				btScanLib_X.FdColumnMin07 = obj.min07;
				btScanLib_X.FdColumnMin08 = obj.min08;
				btScanLib_X.FdColumnMin09 = obj.min09;
				btScanLib_X.FdColumnMin10 = obj.min10;
				btScanLib_X.FdColumnMin11 = obj.min11;
				btScanLib_X.FdColumnMin12 = obj.min12;
				btScanLib_X.FdColumnMin13 = obj.min13;
				btScanLib_X.FdColumnMin14 = obj.min14;
				btScanLib_X.FdColumnMin15 = obj.min15;
				btScanLib_X.FdColumnMin16 = obj.min16;

				btScanLib_X.FdColumnMax01 = obj.max01;
				btScanLib_X.FdColumnMax02 = obj.max02;
				btScanLib_X.FdColumnMax03 = obj.max03;
				btScanLib_X.FdColumnMax04 = obj.max04;
				btScanLib_X.FdColumnMax05 = obj.max05;
				btScanLib_X.FdColumnMax06 = obj.max06;
				btScanLib_X.FdColumnMax07 = obj.max07;
				btScanLib_X.FdColumnMax08 = obj.max08;
				btScanLib_X.FdColumnMax09 = obj.max09;
				btScanLib_X.FdColumnMax10 = obj.max10;
				btScanLib_X.FdColumnMax11 = obj.max11;
				btScanLib_X.FdColumnMax12 = obj.max12;
				btScanLib_X.FdColumnMax13 = obj.max13;
				btScanLib_X.FdColumnMax14 = obj.max14;
				btScanLib_X.FdColumnMax15 = obj.max15;
				btScanLib_X.FdColumnMax16 = obj.max16;
				
				btScanLib_X.FdCodesetType01 = obj.type01;
				btScanLib_X.FdCodesetType02 = obj.type02;
				btScanLib_X.FdCodesetType03 = obj.type03;
				btScanLib_X.FdCodesetType04 = obj.type04;
				btScanLib_X.FdCodesetCodecount01 = obj.codecount01;
				btScanLib_X.FdCodesetCodecount02 = obj.codecount02;
				btScanLib_X.FdCodesetCodecount03 = obj.codecount03;
				btScanLib_X.FdCodesetCodecount04 = obj.codecount04;

				btScanLib_X.FdSetTypecount = obj.typecount;
				btScanLib_X.FdSetRsv1 = obj.rsv1;
				break;

			// obj: ScanProperty class
			case Bt.LibDef.BT_SCAN_PROP_CODELINK:				// Barcode link function
				btScanLib_X.ScanPropCodeLink = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_TRIGGER_MODE:			// Trigger mode
				btScanLib_X.ScanPropTriggerMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_CLRKEY_MODE:			// Cancel key setting
				btScanLib_X.ScanPropClrkeyMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_SEPARATOR_COUNT:		// Count the number of separator digits
				btScanLib_X.ScanPropSeparatorCount = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_SEPARATOR_CODE:		// Separator code
				btScanLib_X.ScanPropSeparatorCode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_SCAN_TIMEOUT:			// Scan timeout
				btScanLib_X.ScanPropScanTimeout = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_DECODE_TIMEOUT:		// Decode timeout
				btScanLib_X.ScanPropDecodeTimeout = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_CONTINUOUS_TIME:		// Prevention time of twice reading
				btScanLib_X.ScanPropContinuosTime = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_SUCCESS_TIMES:		// Matching times
				btScanLib_X.ScanPropSuccessTimes = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_INVERSE:				// Inversion code reading
				btScanLib_X.ScanPropInverse = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_SCAN_TYPE:			// Scan type
				btScanLib_X.ScanPropScanType = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_SCAN_LEVEL:			// Scan Level
				btScanLib_X.ScanPropScanLevel = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_ILLUMINATION:			// Lighting control
				btScanLib_X.ScanPropIllumination = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_FOCUS_MODE:			// [2D]Focus mode
				btScanLib_X.ScanPropFocusMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_INIT_FOCUS_POS:			// [2D]Focus position for auto focus
				btScanLib_X.ScanPropInitFocusPos = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_FIXED_FOCUS_POS:		// [2D]Focus position for fixed focus
				btScanLib_X.ScanPropFixedFocusPos = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_EXT_ILLUMINATION:		// [2D]External lighting
				btScanLib_X.ScanExtIllumination = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_3D_ILLUMINATION:		// (Reserved) [2D]3D character reading
				btScanLib_X.Scan3D_Illumination = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_LIVEVIEW_DECODING:		// [2D]Display liveview decoding
				btScanLib_X.ScanLiveviewDecoding = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_TARGET_BRIGHTNESS:		// [2D]Target brightness
				btScanLib_X.TargetBrightnessNolight	= obj.BrightnessNolight;
				btScanLib_X.TargetBrightnessNormal	= obj.BrightnessNormal;
				btScanLib_X.TargetBrightnessMulti	= obj.BrightnessMulti;
				btScanLib_X.TargetBrightnessLow		= obj.BrightnessLow;
				btScanLib_X.TargetBrightness3D		= obj.Brightness3D;
				btScanLib_X.TargetBrightnessArea	= obj.Area;
				break;
			case Bt.LibDef.BT_SCAN_PROP_DISTANCE_LED:			// [[2D]Reading distance display LED
				btScanLib_X.DistanceLED = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_LASER_MODE:			// [1D]Laser mode
				btScanLib_X.ScanPropLaserMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_ENABLE_DEV:			// OCR Alert: Device Enable/Disable
				btScanLib_X.ScanPropOcrEnableDev = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_DISP_CHECK:			// Display of the recognition result and editing
				btScanLib_X.ScanPropOcrDispCheck = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ENABLE_COMBI:			// Combination of reading
				btScanLib_X.ScanPropOcrEnableCombi = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_RMODE:			// OCR Reading mode
				btScanLib_X.ScanPropOcrRmode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_RPATTERN:			// OCR Recognition pattern
				btScanLib_X.ScanPropOcrRpattern = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_INVERSE:			// OCR Color inversion
				btScanLib_X.ScanPropOcrInverse = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_CHAR_SIZE:			// Enable the reading of small text size
				btScanLib_X.ScanPropOcrCharSize = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ROTATE:			// Direction to be read
				btScanLib_X.ScanPropOcrRotate = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_CONTINUOUS_MARK:			// Enable the reading of continuous mark
				btScanLib_X.ScanPropOcrContinuousMark = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_MARK_SKIP:			// Set output pattern of read marks as result
				btScanLib_X.ScanPropOcrMarkSkip = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_AD_DIGIT:			// A.D. digit
				btScanLib_X.ScanPropOcrAdDigit = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_DAY_EXIST:			// Date notation
				btScanLib_X.ScanPropOcrDayExist = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_1DIGIT_MM_DD:			// Read month, day of 1-digit
				btScanLib_X.ScanPropOcr1DigitMMDD = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_DATE_DELIM:			// Date separator
				btScanLib_X.ScanPropOcrDateDelim = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_DATE_FORMAT:			// Date output pattern
				btScanLib_X.ScanPropOcrOutDateFormat = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_DATE_DELIM:			// Date output separator
				btScanLib_X.ScanPropOcrOutDateDelim = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_ALERT_THRESH:			// Alert frequency
				btScanLib_X.ScanPropOcrOutAlertThresh = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_ALERT_NOTSUCCESS:			// Fail reading when alert occurs
				btScanLib_X.ScanPropOcrOutAlertNotsuccess = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_SHORT_DIGIT:			// Enable one/two digits reading
				btScanLib_X.ScanPropOcrShortDigit = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_VMARGIN:				// Enable with no margin top and bottom
				btScanLib_X.ScanPropOcrVMargin = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_HEIGHT_UNEVEN:			// Enable reading of height is uneven
				btScanLib_X.ScanPropOcrHeightUneven = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ACROSS_BORDER:			// Enable reading across the border
				btScanLib_X.ScanPropOcrAcrossBorder = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_EASE_FAILURE:			// Enable reading of unreliable string (Fail reading increases)
				btScanLib_X.ScanPropOcrEaseFailure = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_PASSPORT_CHECK_DIGIT:			// Enable check digits (for passport reading)
				btScanLib_X.ScanPropOcrPassportCheckDigit = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_PASSPORT_IGNORE_OPTIONAL_DATA:	// Enable ignore optional data (for passport reading)
				btScanLib_X.ScanPropOcrPassportIgnoreOptionalData = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_PASSPORT_CHECK_ICAO_FORMAT:		// Enable ICAO format check (for passport reading)
				btScanLib_X.ScanPropOcrPassportCheckICAOFormat = obj.prop;
				break;				
			case Bt.LibDef.BT_SCAN_PROP_OCR_DATE_ORDER:			// Date order format
				btScanLib_X.ScanPropOcrDateOrder = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_M_ALPHABET:			// Read alphabet month
				btScanLib_X.ScanPropOcrMAlphabet = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_D_KANJI_BME:		// Read "è„Åh, ÅgíÜÅh, Ågâ∫"	#Kanji in Japanese
				btScanLib_X.ScanPropOcrDKanjiBME = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_REPL_B:				// A day converted from Ågè„Åh	#Kanji in Japanese
				btScanLib_X.ScanPropOcrReplB = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_REPL_M:				// A day converted from ÅgíÜÅh	#Kanji in Japanese
				btScanLib_X.ScanPropOcrReplM = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_REPL_E:				// A day converted from Ågâ∫Åh	#Kanji in Japanese
				btScanLib_X.ScanPropOcrReplE = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_BG_PATTERN:			// Enable reading on the patterns
				btScanLib_X.ScanPropOcrBgPattern = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_BG_PATTERN_DEPTH:	// Depth of background patterns
				btScanLib_X.ScanPropOcrBgPatternDepth = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_LOWERCASE_ALPHABET:	// Enable the reading of lowercase characters
				btScanLib_X.ScanPropOcrLowerCaseAlphabet = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_7SEG_MODE:			// 7-segment character string reading mode
				btScanLib_X.ScanPropOcr7SegMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_OUTPUT_SPACE:		// Add spaces identified in the read data
				btScanLib_X.ScanPropOcrOutputSpace = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_CUTOUT_MODE:		// Reading range
				btScanLib_X.ScanPropOcrCutoutMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_DETECTION_MODE:		// Detection mode
				btScanLib_X.ScanPropOcrDetectionMode = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_REMOVE_RULED_LINE:	// Delete straight lines.
				btScanLib_X.ScanPropOcrRemoveRuledLine = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_TOUCHED_CHAR_TB:	// Contacting characters (vertical)
				btScanLib_X.ScanPropOcrTouchedCharTB = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_TOUCHED_CHAR_LR:	// Contacting characters (horizontal)
				btScanLib_X.ScanPropOcrTouchedCharLR = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_DISP_DATE_CHOICE:	// Date candidate selection screen display
				btScanLib_X.ScanPropOcrDispDateChoice = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_DATE_CHOICE_DELIM:	// Inter-candidate separator code for date selection
				btScanLib_X.ScanPropOcrDateChoiceDelim = obj.prop;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_MIRROR:				// Mirror
				btScanLib_X.ScanOcrMirror = obj.prop;
				break;

			// obj: BT_BUZZER_PARAM class
			case Bt.LibDef.BT_SCAN_PROP_COMPLETE_BUZ:			// Read Success: Buzzer
			case Bt.LibDef.BT_SCAN_PROP_STIMEOUT_BUZ:			// Scan Timeout: Buzzer
			case Bt.LibDef.BT_SCAN_PROP_DTIMEOUT_BUZ:			// Decode Timeout: Buzzer
			case Bt.LibDef.BT_SCAN_PROP_CANCEL_BUZ:			// Cancel at reading: Buzzer
				btScanLib_X.BuzzerOn = obj.on;
				btScanLib_X.BuzzerOff = obj.off;
				btScanLib_X.BuzzerCount = obj.count;
				btScanLib_X.BuzzerTone = obj.tone;
				btScanLib_X.BuzzerVolume = obj.volume;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_BUZ:			// OCR Alert: Buzzer
				btScanLib_X.AlertBuzzerOn = obj.on;
				btScanLib_X.AlertBuzzerOff = obj.off;
				btScanLib_X.AlertBuzzerCount = obj.count;
				btScanLib_X.AlertBuzzerTone = obj.tone;
				btScanLib_X.AlertBuzzerVolume = obj.volume;
				break;

			// obj: BT_LED_PARAM class
			case Bt.LibDef.BT_SCAN_PROP_COMPLETE_LED:			// Read Success: LED
			case Bt.LibDef.BT_SCAN_PROP_STIMEOUT_LED:			// Scan Timeout: LED
			case Bt.LibDef.BT_SCAN_PROP_DTIMEOUT_LED:			// Decode Timeout: LED
			case Bt.LibDef.BT_SCAN_PROP_CANCEL_LED:			// Cancel at reading: LED
				btScanLib_X.LedOn = obj.on;
				btScanLib_X.LedOff = obj.off;
				btScanLib_X.LedCount = obj.count;
				btScanLib_X.LedColor = obj.color;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_LED:			// OCR Alert: LED
				btScanLib_X.AlertLedOn = obj.on;
				btScanLib_X.AlertLedOff = obj.off;
				btScanLib_X.AlertLedCount = obj.count;
				btScanLib_X.AlertLedColor = obj.color;
				break;

			// obj: BT_VIBRATOR_PARAM class
			case Bt.LibDef.BT_SCAN_PROP_COMPLETE_VIB:			// Read Success: Vibrator
			case Bt.LibDef.BT_SCAN_PROP_STIMEOUT_VIB:			// Scan Timeout: Vibrator
			case Bt.LibDef.BT_SCAN_PROP_DTIMEOUT_VIB:			// Decode Timeout: Vibrator
			case Bt.LibDef.BT_SCAN_PROP_CANCEL_VIB:			// Cancel at reading: Vibrator
				btScanLib_X.VibOn = obj.on;
				btScanLib_X.VibOff = obj.off;
				btScanLib_X.VibCount = obj.count;
				break;
			case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_VIB:			// OCR Alert: Vibrator
				btScanLib_X.AlertVibOn = obj.on;
				btScanLib_X.AlertVibOff = obj.off;
				btScanLib_X.AlertVibCount = obj.count;
				break;

			// obj: BT_SCAN_OCR_SIMPLE_FORMAT class
			case Bt.LibDef.BT_SCAN_PROP_OCR_SFORMAT:			// Range restriction
				btScanLib_X.Sformat_Valid = obj.valid;
				btScanLib_X.Sformat_CharType = obj.CharType;
				btScanLib_X.Sformat_CharRangeMin = obj.CharRangeMin;
				btScanLib_X.Sformat_CharRangeMax = obj.CharRangeMax;
				btScanLib_X.Sformat_Lmargin = obj.LMargin;
				btScanLib_X.Sformat_Rmargin = obj.RMargin;
				break;

			// obj: BT_SCAN_OCR_DETAIL_FORMAT class
			case Bt.LibDef.BT_SCAN_PROP_OCR_DFORMAT:				// Format registration
				btScanLib_X.Dformat_FormatNumber = obj.FormatNumber;
				btScanLib_X.Dformat_valid = obj.valid;
				btScanLib_X.Dformat_CharLen = obj.CharLen;
				btScanLib_X.Dformat_Lmargin = obj.LMargin;
				btScanLib_X.Dformat_Rmargin = obj.RMargin;
				break;

			// obj: BT_SCAN_OCR_RECOG_DATE class
			case Bt.LibDef.BT_SCAN_PROP_OCR_RECOG_DATE:				// Date recognition range
				btScanLib_X.OcrCalendar_YearStart = obj.yearStart;
				btScanLib_X.OcrCalendar_MonthStart = obj.monthStart;
				btScanLib_X.OcrCalendar_DayStart = obj.dayStart;
				btScanLib_X.OcrCalendar_YearEnd = obj.yearEnd;
				btScanLib_X.OcrCalendar_MonthEnd = obj.monthEnd;
				btScanLib_X.OcrCalendar_DayEnd = obj.dayEnd;
				break;

			// obj: BT_SCAN_OCR_ERA class
			case Bt.LibDef.BT_SCAN_PROP_OCR_ERA:				// Read Japanese calendar
				btScanLib_X.OcrEra_Valid1 = obj.valid1;
				btScanLib_X.OcrEra_FirstYear1 = obj.FirstYear1;
				btScanLib_X.OcrEra_Min1 = obj.RangeMin1;
				btScanLib_X.OcrEra_Max1 = obj.RangeMax1;
				btScanLib_X.OcrEra_Valid2 = obj.valid2;
				btScanLib_X.OcrEra_FirstYear2 = obj.FirstYear2;
				btScanLib_X.OcrEra_Min2 = obj.RangeMin2;
				btScanLib_X.OcrEra_Max2 = obj.RangeMax2;
				break;

			// obj: BT_SCAN_OCR_STR_OUTPUT_FMT class
			case Bt.LibDef.BT_SCAN_PROP_OCR_STR_OUTPUT_FORMAT:	// Excluded character specification
				btScanLib_X.StrOutputFmt_valid = obj.valid;
				btScanLib_X.StrOutputFmt_rsv1 = obj.rsv1;
				break;

			// obj: BT_SCAN_PROP_OCR_MULTI_STR class
			case Bt.LibDef.BT_SCAN_PROP_OCR_MULTI_STR:			// Batch reading of multiple character strings
				btScanLib_X.MultiStr_valid			= obj.valid;			// Enable setting (0: disable, 1:enable)
				btScanLib_X.MultiStr_strcount		= obj.strcount;			// Number of character strings
				btScanLib_X.MultiStr_position		= obj.position;			// Character order within the string
				btScanLib_X.MultiStr_pattern1		= obj.pattern1;			// OCR recognition pattern 1 (BT_SCAN_OCR_RPATTERN_XXX)
				btScanLib_X.MultiStr_pattern2		= obj.pattern2;			// OCR recognition pattern 2 (BT_SCAN_OCR_RPATTERN_XXX)
				btScanLib_X.MultiStr_pattern3		= obj.pattern3;			// OCR recognition pattern 3 (BT_SCAN_OCR_RPATTERN_XXX)
				btScanLib_X.MultiStr_pattern4		= obj.pattern4;			// OCR recognition pattern 4 (BT_SCAN_OCR_RPATTERN_XXX)
				btScanLib_X.MultiStr_OutputSeparator= obj.OutputSeparator;	// Separator output
				btScanLib_X.MultiStr_separator		= obj.separator;		// Character code of separator
				break;
		}

		return btScanLib_X.btScanSetProperty( id );	//Execute ActiveX method

	};

	//********************************************************************************
	// * @brief	Function:@n	[Get scan property]
	// * @n
	// * @param	[in]	id		:ID
	// * @param	[out]	obj		:Property value (ScanProperty class, or another class)
	// * @n
	// * @return	Refer to the terminal library reference
	//********************************************************************************/
	ScanLib.Setting.btScanGetProperty = function( id, obj )
	{
		var ret = btScanLib_X.btScanGetProperty( id );	//Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			//Get property
			switch(id)
			{
				// obj: BT_CODESET_XXX class
				case Bt.LibDef.BT_SCAN_PROP_JAN:					// JAN property
					obj.adgap_min = btScanLib_X.JanAdGap_min;
					obj.adgap_max = btScanLib_X.JanAdGap_max;
					obj.flgset = btScanLib_X.JanFlgset;
					break;
				case Bt.LibDef.BT_SCAN_PROP_CODE39:				// Code39 property
					obj.min = btScanLib_X.C39Min;
					obj.max = btScanLib_X.C39Max;
					obj.flgset = btScanLib_X.C39Flgset;
					obj.rsv1 = btScanLib_X.C39Rsv1;
					break;
				case Bt.LibDef.BT_SCAN_PROP_CODE128:				// Code128 property
					obj.min = btScanLib_X.C128Min;
					obj.max = btScanLib_X.C128Max;
					obj.flgset = btScanLib_X.C128Flgset;
					obj.rsv1 = btScanLib_X.C128Rsv1;
					break;		
				case Bt.LibDef.BT_SCAN_PROP_GS1_128:				// GS1-128 property
					obj.min = btScanLib_X.Gs128Min;
					obj.max = btScanLib_X.Gs128Max;
					obj.flgset = btScanLib_X.Gs128Flgset;
					obj.separator = btScanLib_X.Gs128Separator;
					obj.rsv = btScanLib_X.Gs128Rsv;
					break;
				case Bt.LibDef.BT_SCAN_PROP_NW7:					// NW7 property
					obj.min = btScanLib_X.Nw7Min;
					obj.max = btScanLib_X.Nw7Max;
					obj.flgset = btScanLib_X.Nw7Flgset;
					obj.rsv1 = btScanLib_X.Nw7Rsv1;
					break;
				case Bt.LibDef.BT_SCAN_PROP_ITF:					// ITF property
					obj.min = btScanLib_X.ItfMin;
					obj.max = btScanLib_X.ItfMax;
					obj.flgset = btScanLib_X.ItfFlgset;
					obj.rsv1 = btScanLib_X.ItfRsv1;
					break;
				case Bt.LibDef.BT_SCAN_PROP_CODE93:				// Code93 property
					obj.min = btScanLib_X.C93Min;
					obj.max = btScanLib_X.C93Max;
					obj.flgset = btScanLib_X.C93Flgset;
					obj.rsv1 = btScanLib_X.C93Rsv1;
					break;
				case Bt.LibDef.BT_SCAN_PROP_TOF:					// TOF property
					obj.min = btScanLib_X.TofMin;
					obj.max = btScanLib_X.TofMax;
					break;
				case Bt.LibDef.BT_SCAN_PROP_COOP:					// COOP property
					obj.min = btScanLib_X.CoopMin;
					obj.max = btScanLib_X.CoopMax;
					break;
				case Bt.LibDef.BT_SCAN_PROP_GS1_DB:				// GS1 DataBar property
					obj.min = btScanLib_X.GsdMin;
					obj.max = btScanLib_X.GsdMax;
					obj.flgset = btScanLib_X.GsdFlgset;
					break;
				case Bt.LibDef.BT_SCAN_PROP_QR:					// QR property
					obj.min = btScanLib_X.QrMin;
					obj.max = btScanLib_X.QrMax;
					obj.flgset = btScanLib_X.QrFlgset;
					break;
				case Bt.LibDef.BT_SCAN_PROP_PDF:					// PDF417 property
					obj.min = btScanLib_X.PdfMin;
					obj.max = btScanLib_X.PdfMax;
					obj.flgset = btScanLib_X.PdfFlgset;
					break;
				case Bt.LibDef.BT_SCAN_PROP_DM:					// DataMatrix property
					obj.min = btScanLib_X.DmMin;
					obj.max = btScanLib_X.DmMax;
					obj.flgset = btScanLib_X.DmFlgset;
					break;
				case Bt.LibDef.BT_SCAN_PROP_MC:					// MaxiCode property
					obj.min = btScanLib_X.McMin;
					obj.max = btScanLib_X.McMax;
					obj.flgset = btScanLib_X.McFlgset;
					break;
				case Bt.LibDef.BT_SCAN_PROP_COMPOSITE:			// Composite symbol property
					obj.flgset = btScanLib_X.CompFlgset;
					obj.separator = btScanLib_X.CompSeparator;
					obj.rsv = btScanLib_X.CompRsv;
					break;
				case Bt.LibDef.BT_SCAN_PROP_ENABLE_SYMBOLS:		// Code permitted to read
					obj.prop = btScanLib_X.ScanPropEnableSymbol;
					break;

				// obj: BT_SCAN_FD_SET_PARAM class
				case Bt.LibDef.BT_SCAN_PROP_FULLDETECTION:		// Multi code setting
					obj.min01 = btScanLib_X.FdColumnMin01;
					obj.min02 = btScanLib_X.FdColumnMin02;
					obj.min03 = btScanLib_X.FdColumnMin03;
					obj.min04 = btScanLib_X.FdColumnMin04;
					obj.min05 = btScanLib_X.FdColumnMin05;
					obj.min06 = btScanLib_X.FdColumnMin06;
					obj.min07 = btScanLib_X.FdColumnMin07;
					obj.min08 = btScanLib_X.FdColumnMin08;
					obj.min09 = btScanLib_X.FdColumnMin09;
					obj.min10 = btScanLib_X.FdColumnMin10;
					obj.min11 = btScanLib_X.FdColumnMin11;
					obj.min12 = btScanLib_X.FdColumnMin12;
					obj.min13 = btScanLib_X.FdColumnMin13;
					obj.min14 = btScanLib_X.FdColumnMin14;
					obj.min15 = btScanLib_X.FdColumnMin15;
					obj.min16 = btScanLib_X.FdColumnMin16;

					obj.max01 = btScanLib_X.FdColumnMax01;
					obj.max02 = btScanLib_X.FdColumnMax02;
					obj.max03 = btScanLib_X.FdColumnMax03;
					obj.max04 = btScanLib_X.FdColumnMax04;
					obj.max05 = btScanLib_X.FdColumnMax05;
					obj.max06 = btScanLib_X.FdColumnMax06;
					obj.max07 = btScanLib_X.FdColumnMax07;
					obj.max08 = btScanLib_X.FdColumnMax08;
					obj.max09 = btScanLib_X.FdColumnMax09;
					obj.max10 = btScanLib_X.FdColumnMax10;
					obj.max11 = btScanLib_X.FdColumnMax11;
					obj.max12 = btScanLib_X.FdColumnMax12;
					obj.max13 = btScanLib_X.FdColumnMax13;
					obj.max14 = btScanLib_X.FdColumnMax14;
					obj.max15 = btScanLib_X.FdColumnMax15;
					obj.max16 = btScanLib_X.FdColumnMax16;

					obj.type01 = btScanLib_X.FdCodesetType01;
					obj.type02 = btScanLib_X.FdCodesetType02;
					obj.type03 = btScanLib_X.FdCodesetType03;
					obj.type04 = btScanLib_X.FdCodesetType04;
					obj.codecount01 = btScanLib_X.FdCodesetCodecount01;
					obj.codecount02 = btScanLib_X.FdCodesetCodecount02;
					obj.codecount03 = btScanLib_X.FdCodesetCodecount03;
					obj.codecount04 = btScanLib_X.FdCodesetCodecount04;

					obj.typecount = btScanLib_X.FdSetTypecount;
					obj.rsv1 = btScanLib_X.FdSetRsv1;
					break;

				// obj: ScanProperty class
				case Bt.LibDef.BT_SCAN_PROP_CODELINK:				// Barcode link function
					obj.prop = btScanLib_X.ScanPropCodeLink;
					break;
				case Bt.LibDef.BT_SCAN_PROP_TRIGGER_MODE:			// Trigger mode
					obj.prop = btScanLib_X.ScanPropTriggerMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_CLRKEY_MODE:			// Cancel key setting
					obj.prop = btScanLib_X.ScanPropClrkeyMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_SEPARATOR_COUNT:		// Count the number of separator digits
					obj.prop = btScanLib_X.ScanPropSeparatorCount;
					break;
				case Bt.LibDef.BT_SCAN_PROP_SEPARATOR_CODE:		// Separator code
					obj.prop = btScanLib_X.ScanPropSeparatorCode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_SCAN_TIMEOUT:			// Scan timeout
					obj.prop = btScanLib_X.ScanPropScanTimeout;
					break;
				case Bt.LibDef.BT_SCAN_PROP_DECODE_TIMEOUT:		// Decode timeout
					obj.prop = btScanLib_X.ScanPropDecodeTimeout;
					break;
				case Bt.LibDef.BT_SCAN_PROP_CONTINUOUS_TIME:		// Prevention time of twice reading
					obj.prop = btScanLib_X.ScanPropContinuosTime;
					break;
				case Bt.LibDef.BT_SCAN_PROP_SUCCESS_TIMES:		// Matching times
					obj.prop = btScanLib_X.ScanPropSuccessTimes;
					break;
				case Bt.LibDef.BT_SCAN_PROP_INVERSE:				// Inversion code reading
					obj.prop = btScanLib_X.ScanPropInverse;
					break;
				case Bt.LibDef.BT_SCAN_PROP_SCAN_TYPE:			// Scan type
					obj.prop = btScanLib_X.ScanPropScanType;
					break;
				case Bt.LibDef.BT_SCAN_PROP_SCAN_LEVEL:			// Scan Level
					obj.prop = btScanLib_X.ScanPropScanLevel;
					break;
				case Bt.LibDef.BT_SCAN_PROP_ILLUMINATION:			// Lighting control
					obj.prop = btScanLib_X.ScanPropIllumination;
					break;
				case Bt.LibDef.BT_SCAN_PROP_FOCUS_MODE:			// [2D]Focus mode
					obj.prop = btScanLib_X.ScanPropFocusMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_INIT_FOCUS_POS:			// [2D]Focus position for auto focus
					obj.prop = btScanLib_X.ScanPropInitFocusPos;
					break;
				case Bt.LibDef.BT_SCAN_PROP_FIXED_FOCUS_POS:		// [2D]Focus position for fixed focus
					obj.prop = btScanLib_X.ScanPropFixedFocusPos;
					break;
				case Bt.LibDef.BT_SCAN_PROP_EXT_ILLUMINATION:		// [2D]External lighting
					obj.prop = btScanLib_X.ScanExtIllumination;
					break;
				case Bt.LibDef.BT_SCAN_PROP_3D_ILLUMINATION:		// (Reserved) [2D]3D character reading
					obj.prop = btScanLib_X.Scan3D_Illumination;
					break;
				case Bt.LibDef.BT_SCAN_PROP_LIVEVIEW_DECODING:		// [2D]Display liveview decoding
					obj.prop = btScanLib_X.ScanLiveviewDecoding;
					break;
				case Bt.LibDef.BT_SCAN_PROP_TARGET_BRIGHTNESS:		// [2D]Target brightness
					obj.BrightnessNolight	= btScanLib_X.TargetBrightnessNolight;
					obj.BrightnessNormal	= btScanLib_X.TargetBrightnessNormal;
					obj.BrightnessMulti		= btScanLib_X.TargetBrightnessMulti;
					obj.BrightnessLow		= btScanLib_X.TargetBrightnessLow;
					obj.Brightness3D		= btScanLib_X.TargetBrightness3D;
					obj.Area				= btScanLib_X.TargetBrightnessArea;
					break;
				case Bt.LibDef.BT_SCAN_PROP_DISTANCE_LED:			// [2D]Reading distance display LED
					obj.prop = btScanLib_X.DistanceLED;
					break;
				case Bt.LibDef.BT_SCAN_PROP_LASER_MODE:			// [1D]Laser mode
					obj.prop = btScanLib_X.ScanPropLaserMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_ENABLE_DEV:			// OCR Alert: Device Enable/Disable
					obj.prop = btScanLib_X.ScanPropOcrEnableDev;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DISP_CHECK:			// Display of the recognition result and editing
					obj.prop = btScanLib_X.ScanPropOcrDispCheck;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ENABLE_COMBI:			// Combination of reading
					obj.prop = btScanLib_X.ScanPropOcrEnableCombi;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_RMODE:			// OCR Reading mode
					obj.prop = btScanLib_X.ScanPropOcrRmode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_RPATTERN:			// OCR Recognition pattern
					obj.prop = btScanLib_X.ScanPropOcrRpattern;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_INVERSE:			// OCR Color inversion
					obj.prop = btScanLib_X.ScanPropOcrInverse;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_CHAR_SIZE:			// Enable the reading of small text size
					obj.prop = btScanLib_X.ScanPropOcrCharSize;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ROTATE:			// Direction to be read
					obj.prop = btScanLib_X.ScanPropOcrRotate;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_CONTINUOUS_MARK:			// Enable the reading of continuous mark
					obj.prop = btScanLib_X.ScanPropOcrContinuousMark;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_MARK_SKIP:			// Set output pattern of read marks as result
					obj.prop = btScanLib_X.ScanPropOcrMarkSkip;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_AD_DIGIT:			// A.D. digit
					obj.prop = btScanLib_X.ScanPropOcrAdDigit;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DAY_EXIST:			// Date notation
					obj.prop = btScanLib_X.ScanPropOcrDayExist;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_1DIGIT_MM_DD:			// Read month, day of 1-digit
					obj.prop = btScanLib_X.ScanPropOcr1DigitMMDD;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DATE_DELIM:			// Date separator
					obj.prop = btScanLib_X.ScanPropOcrDateDelim;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_DATE_FORMAT:			// Date output pattern
					obj.prop = btScanLib_X.ScanPropOcrOutDateFormat;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_DATE_DELIM:			// Date output separator
					obj.prop = btScanLib_X.ScanPropOcrOutDateDelim;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_ALERT_THRESH:			// Alert frequency
					obj.prop = btScanLib_X.ScanPropOcrOutAlertThresh;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_OUT_ALERT_NOTSUCCESS:			// Fail reading when alert occurs
					obj.prop = btScanLib_X.ScanPropOcrOutAlertNotsuccess;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_SHORT_DIGIT:			// Enable one/two digits reading
					obj.prop = btScanLib_X.ScanPropOcrShortDigit;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_VMARGIN:				// Enable with no margin top and bottom
					obj.prop = btScanLib_X.ScanPropOcrVMargin;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_HEIGHT_UNEVEN:			// Enable reading of height is uneven
					obj.prop = btScanLib_X.ScanPropOcrHeightUneven;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ACROSS_BORDER:			// Enable reading across the border
					obj.prop = btScanLib_X.ScanPropOcrAcrossBorder;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_EASE_FAILURE:			// Enable reading of unreliable string (Fail reading increases)
					obj.prop = btScanLib_X.ScanPropOcrEaseFailure;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_PASSPORT_CHECK_DIGIT:				// Enable check digits (for passport reading)
					obj.prop = btScanLib_X.ScanPropOcrPassportCheckDigit;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_PASSPORT_IGNORE_OPTIONAL_DATA:		// Enable ignore optional data (for passport reading)
					obj.prop = btScanLib_X.ScanPropOcrPassportIgnoreOptionalData;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_PASSPORT_CHECK_ICAO_FORMAT:			// Enable ICAO format check (for passport reading)
					obj.prop = btScanLib_X.ScanPropOcrPassportCheckICAOFormat;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DATE_ORDER:			// Date order format
					obj.prop = btScanLib_X.ScanPropOcrDateOrder;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_M_ALPHABET:			// Read alphabet month
					obj.prop = btScanLib_X.ScanPropOcrMAlphabet;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_D_KANJI_BME:		// Read "è„Åh, ÅgíÜÅh, Ågâ∫"	#Kanji in Japanese
					obj.prop = btScanLib_X.ScanPropOcrDKanjiBME;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_REPL_B:				// A day converted from Ågè„Åh	#Kanji in Japanese
					obj.prop = btScanLib_X.ScanPropOcrReplB;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_REPL_M:				// A day converted from ÅgíÜÅh	#Kanji in Japanese
					obj.prop = btScanLib_X.ScanPropOcrReplM;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_REPL_E:				// A day converted from Ågâ∫Åh	#Kanji in Japanese
					obj.prop = btScanLib_X.ScanPropOcrReplE;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_BG_PATTERN:			// Enable reading on the patterns
					obj.prop = btScanLib_X.ScanPropOcrBgPattern;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_BG_PATTERN_DEPTH:	// Depth of background patterns
					obj.prop = btScanLib_X.ScanPropOcrBgPatternDepth;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_LOWERCASE_ALPHABET:	// Enable the reading of lowercase characters
					obj.prop = btScanLib_X.ScanPropOcrLowerCaseAlphabet;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_7SEG_MODE:			// 7-segment character string reading mode
					obj.prop = btScanLib_X.ScanPropOcr7SegMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_OUTPUT_SPACE:		// Add spaces identified in the read data
					obj.prop = btScanLib_X.ScanPropOcrOutputSpace;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_CUTOUT_MODE:		// Reading range
					obj.prop = btScanLib_X.ScanPropOcrCutoutMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DETECTION_MODE:		// Detection mode
					obj.prop = btScanLib_X.ScanPropOcrDetectionMode;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_REMOVE_RULED_LINE:	// Delete straight lines.
					obj.prop = btScanLib_X.ScanPropOcrRemoveRuledLine;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_TOUCHED_CHAR_TB:	// Contacting characters (vertical)
					obj.prop = btScanLib_X.ScanPropOcrTouchedCharTB;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_TOUCHED_CHAR_LR:	// Contacting characters (horizontal)
					obj.prop = btScanLib_X.ScanPropOcrTouchedCharLR;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DISP_DATE_CHOICE:	// Date candidate selection screen display
					obj.prop = btScanLib_X.ScanPropOcrDispDateChoice;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_DATE_CHOICE_DELIM:	// Inter-candidate separator code for date selection
					obj.prop = btScanLib_X.ScanPropOcrDateChoiceDelim;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_MIRROR:				// Mirror
					obj.prop = btScanLib_X.ScanOcrMirror;
					break;

				// obj: BT_BUZZER_PARAM class
				case Bt.LibDef.BT_SCAN_PROP_COMPLETE_BUZ:			// Read Success: Buzzer
				case Bt.LibDef.BT_SCAN_PROP_STIMEOUT_BUZ:			// Scan Timeout: Buzzer
				case Bt.LibDef.BT_SCAN_PROP_DTIMEOUT_BUZ:			// Decode Timeout: Buzzer
				case Bt.LibDef.BT_SCAN_PROP_CANCEL_BUZ:			// Cancel at reading: Buzzer
					obj.on = btScanLib_X.BuzzerOn;
					obj.off = btScanLib_X.BuzzerOff;
					obj.count = btScanLib_X.BuzzerCount;
					obj.tone = btScanLib_X.BuzzerTone;
					obj.volume = btScanLib_X.BuzzerVolume;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_BUZ:			// OCR Alert: Buzzer
					obj.on = btScanLib_X.AlertBuzzerOn;
					obj.off = btScanLib_X.AlertBuzzerOff;
					obj.count = btScanLib_X.AlertBuzzerCount;
					obj.tone = btScanLib_X.AlertBuzzerTone;
					obj.volume = btScanLib_X.AlertBuzzerVolume;
					break;

				// obj: BT_LED_PARAM class
				case Bt.LibDef.BT_SCAN_PROP_COMPLETE_LED:			// Read Success: LED
				case Bt.LibDef.BT_SCAN_PROP_STIMEOUT_LED:			// Scan Timeout: LED
				case Bt.LibDef.BT_SCAN_PROP_DTIMEOUT_LED:			// Decode Timeout: LED
				case Bt.LibDef.BT_SCAN_PROP_CANCEL_LED:			// Cancel at reading: LED
					obj.on = btScanLib_X.LedOn;
					obj.off = btScanLib_X.LedOff;
					obj.count = btScanLib_X.LedCount;
					obj.color = btScanLib_X.LedColor;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_LED:			// OCR Alert: LED
					obj.on = btScanLib_X.AlertLedOn;
					obj.off = btScanLib_X.AlertLedOff;
					obj.count = btScanLib_X.AlertLedCount;
					obj.color = btScanLib_X.AlertLedColor;
					break;

				// obj: BT_VIBRATOR_PARAM class
				case Bt.LibDef.BT_SCAN_PROP_COMPLETE_VIB:			// Read Success: Vibrator
				case Bt.LibDef.BT_SCAN_PROP_STIMEOUT_VIB:			// Scan Timeout: Vibrator
				case Bt.LibDef.BT_SCAN_PROP_DTIMEOUT_VIB:			// Decode Timeout: Vibrator
				case Bt.LibDef.BT_SCAN_PROP_CANCEL_VIB:			// Cancel at reading: Vibrator
					obj.on = btScanLib_X.VibOn;
					obj.off = btScanLib_X.VibOff;
					obj.count = btScanLib_X.VibCount;
					break;
				case Bt.LibDef.BT_SCAN_PROP_OCR_ALERT_VIB:			// OCR Alert: Vibrator
					obj.on = btScanLib_X.AlertVibOn;
					obj.off = btScanLib_X.AlertVibOff;
					obj.count = btScanLib_X.AlertVibCount;
					break;

				// obj: BT_SCAN_OCR_SIMPLE_FORMAT class
				case Bt.LibDef.BT_SCAN_PROP_OCR_SFORMAT:				// Range restriction
					obj.valid = btScanLib_X.Sformat_Valid;
					obj.CharType = btScanLib_X.Sformat_CharType;
					obj.CharRangeMin = btScanLib_X.Sformat_CharRangeMin;
					obj.CharRangeMax = btScanLib_X.Sformat_CharRangeMax;
					obj.LMargin = btScanLib_X.Sformat_Lmargin;
					obj.RMargin = btScanLib_X.Sformat_Rmargin;
					break;

				// obj: BT_SCAN_OCR_DETAIL_FORMAT class
				case Bt.LibDef.BT_SCAN_PROP_OCR_DFORMAT:				// Format registration
					obj.FormatNumber = btScanLib_X.Dformat_FormatNumber;
					obj.valid = btScanLib_X.Dformat_valid;
					obj.CharLen = btScanLib_X.Dformat_CharLen;
					obj.LMargin = btScanLib_X.Dformat_Lmargin;
					obj.RMargin = btScanLib_X.Dformat_Rmargin;
					break;

				// obj: BT_SCAN_OCR_RECOG_DATE class
				case Bt.LibDef.BT_SCAN_PROP_OCR_RECOG_DATE:				// Date recognition range
					obj.yearStart = btScanLib_X.OcrCalendar_YearStart;
					obj.monthStart = btScanLib_X.OcrCalendar_MonthStart;
					obj.dayStart = btScanLib_X.OcrCalendar_DayStart;
					obj.yearEnd = btScanLib_X.OcrCalendar_YearEnd;
					obj.monthEnd = btScanLib_X.OcrCalendar_MonthEnd;
					obj.dayEnd = btScanLib_X.OcrCalendar_DayEnd;
					break;

				// obj: BT_SCAN_OCR_ERA class
				case Bt.LibDef.BT_SCAN_PROP_OCR_ERA:				// Read Japanese calendar
					obj.valid1 = btScanLib_X.OcrEra_Valid1;
					obj.FirstYear1 = btScanLib_X.OcrEra_FirstYear1;
					obj.RangeMin1 = btScanLib_X.OcrEra_Min1;
					obj.RangeMax1 = btScanLib_X.OcrEra_Max1;
					obj.valid2 = btScanLib_X.OcrEra_Valid2;
					obj.FirstYear2 = btScanLib_X.OcrEra_FirstYear2;
					obj.RangeMin2 = btScanLib_X.OcrEra_Min2;
					obj.RangeMax2 = btScanLib_X.OcrEra_Max2;
					break;

				// obj: BT_SCAN_OCR_STR_OUTPUT_FMT class
				case Bt.LibDef.BT_SCAN_PROP_OCR_STR_OUTPUT_FORMAT:	// Excluded character specification
					obj.valid = btScanLib_X.StrOutputFmt_valid;
					obj.rsv1 = btScanLib_X.StrOutputFmt_rsv1;
					break;

				// obj: BT_SCAN_PROP_OCR_MULTI_STR class
				case Bt.LibDef.BT_SCAN_PROP_OCR_MULTI_STR:			// Batch reading of multiple character strings
					obj.valid			= btScanLib_X.MultiStr_valid;			// Enable setting (0: disable, 1:enable)
					obj.strcount		= btScanLib_X.MultiStr_strcount;		// Number of character strings
					obj.position		= btScanLib_X.MultiStr_position;		// Character order within the string
					obj.pattern1		= btScanLib_X.MultiStr_pattern1;		// OCR recognition pattern 1 (BT_SCAN_OCR_RPATTERN_XXX)
					obj.pattern2		= btScanLib_X.MultiStr_pattern2;		// OCR recognition pattern 2 (BT_SCAN_OCR_RPATTERN_XXX)
					obj.pattern3		= btScanLib_X.MultiStr_pattern3;		// OCR recognition pattern 3 (BT_SCAN_OCR_RPATTERN_XXX)
					obj.pattern4		= btScanLib_X.MultiStr_pattern4;		// OCR recognition pattern 4 (BT_SCAN_OCR_RPATTERN_XXX)
					obj.OutputSeparator	= btScanLib_X.MultiStr_OutputSeparator;	// Separator output
					obj.separator		= btScanLib_X.MultiStr_separator;		// Character code of separator
					break;
			}
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Set format of each character (for OCR)]
	// * @n
	// * @param	[in]	index	:Character index(0~)
	// * @param	[in]	obj	:Character settings class (BT_SCAN_OCR_FORMAT_EACH class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanSetOCRFormatEach = function( index, obj )
	{
		btScanLib_X.Dformat_Each_CharMode = obj.CharMode;
		btScanLib_X.Dformat_Each_digits = obj.digits;
		btScanLib_X.Dformat_Each_alphabets = obj.alphabets;
		btScanLib_X.Dformat_Each_marks = obj.marks;
		btScanLib_X.Dformat_Each_reserve = obj.reserve;

		return btScanLib_X.btScanSetOCRFormatEach( index );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get format of each character (for OCR)]
	// * @n
	// * @param	[in]	index	:Character index(0~)
	// * @param	[out]	obj	:Character settings class (BT_SCAN_OCR_FORMAT_EACH class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanGetOCRFormatEach = function( index, obj )
	{
		var ret = btScanLib_X.btScanGetOCRFormatEach( index );	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.CharMode = btScanLib_X.Dformat_Each_CharMode;
			obj.digits = btScanLib_X.Dformat_Each_digits;
			obj.alphabets = btScanLib_X.Dformat_Each_alphabets;
			obj.marks = btScanLib_X.Dformat_Each_marks;
			obj.reserve = btScanLib_X.Dformat_Each_reserve;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get Keyword for specifying a character string to exclude (for OCR)]
	// * @n
	// * @param	[in]	index	:Keyword index(0~)
	// * @param	[out]	obj	:Keyword settings class (BT_SCAN_OCR_STR_OUTPUT_FMT_KEY class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanSetOCRStrOutputFormatKey = function( index, obj )
	{
		btScanLib_X.StrOutputFmt_key_keyword = obj.keyword;
		btScanLib_X.StrOutputFmt_key_reserve = obj.reserve;

		return btScanLib_X.btScanSetOCRStrOutputFormatKey( index );	// Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get Keyword for specifying a character string to exclude (for OCR)]
	// * @n
	// * @param	[in]	index	:Keyword index(0~)
	// * @param	[out]	obj	:Keyword settings class (BT_SCAN_OCR_STR_OUTPUT_FMT_KEY class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanGetOCRStrOutputFormatKey = function( index, obj )
	{
		var ret = btScanLib_X.btScanGetOCRStrOutputFormatKey( index );	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.keyword = btScanLib_X.StrOutputFmt_key_keyword;
			obj.reserve = btScanLib_X.StrOutputFmt_key_reserve;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Set scan property by file input]
	// * @n
	// * @param	[in]	filename	:Input file name
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanLoadConfig = function( filename )
	{
		return btScanLib_X.btScanLoadConfig( filename );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get scan property by file output]
	// * @n
	// * @param	[in]		filename	:Output file name
	// * @param	[in]		overwrite	:Overwrite flag when the same file name exists
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanSaveConfig = function( filename, overwrite )
	{
		return btScanLib_X.btScanSaveConfig( filename, overwrite );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Set scan property by file input (for OCR)]
	// * @n
	// * @param	[in]	filename	:Input file name
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanLoadOCRConfig = function( filename )
	{
		return btScanLib_X.btScanLoadOCRConfig( filename );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get scan property by file output (for OCR)]
	// * @n
	// * @param	[in]		filename	:Output file name
	// * @param	[in]		overwrite	:Overwrite flag when the same file name exists
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanSaveOCRConfig = function( filename, overwrite )
	{
		return btScanLib_X.btScanSaveOCRConfig( filename, overwrite );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Format registration: easy method (for OCR)]
	// * @n
	// * @param	[in]		FormatNumber	:Format registration number (BT_SCAN_OCR_DFMT_BANK_MIN ~ MAX)
	// * @param	[in]		valid			:Enable setting (0: disable, 1:enable)
	// * @param	[in]		target			:Input string
	// * @param	[in]		LMargin			:Margin: Left (0: disable, 1:enable)
	// * @param	[in]		RMargin			:Margin: Right (0: disable, 1:enable)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Setting.btScanRegisterFormat = function( FormatNumber, valid, target, LMargin, RMargin )
	{
		return btScanLib_X.btScanRegisterFormat( FormatNumber, valid, target, LMargin, RMargin );	//Execute ActiveX method
	};

	//------------------------------------------------------------------------
	// Bt.ScanLib.Control
	//------------------------------------------------------------------------
	//********************************************************************************
	// * @brief	Function:@n	[Enable scan function]
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanEnable = function()
	{
		return btScanLib_X.btScanEnable();	//Execute ActiveX method
	};

	/********************************************************************************
	// * @brief	Function:@n	[Disable scan function]
	// * @n
	// * @return	Refer to the terminal library reference
	********************************************************************************/
	ScanLib.Control.btScanDisable = function()
	{
		return btScanLib_X.btScanDisable();	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Contol marker and lights]
	// * @n
	// * @param	[in]	 marker	:Marker ON/OFF
	// * @param	[in]	 led	:Camera light ON/OFF
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanMarker = function( marker, led )
	{
		return btScanLib_X.btScanMarker( marker, led );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Control trigger]
	// * @n
	// * @param	[in]	 trigger	:Trigger ON/OFF
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanSoftTrigger = function( trigger )
	{
		return btScanLib_X.btScanSoftTrigger( trigger );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get number of reading code]
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetResultCount = function()
	{
		return btScanLib_X.btScanGetResultCount();	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get reading code size (each)]
	// * @n
	// * @param	[in]	 index		:Read code index
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetDataSize = function( index )
	{
		return btScanLib_X.btScanGetDataSize( index );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get reading result (each)]
	// * @n
	// * @param	[in]	 index		:Read code index
	// * @param	[out]	 objCode	:Code strings (ScanDataCodeData class)
	// * @param	[out]	 objScan	:Code detail information (BT_SCAN_REPORT class)
	// * @param	[out]	 objQr		:Code detail information for QR (BT_SCAN_QR_REPORT class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetData = function( index, objCode, objScan, objQr )
	{
		var ret = btScanLib_X.btScanGetData(index);	//Execute ActiveX method
		if (ret == Bt.LibDef.BT_OK){
			//Get Code strings property
			objCode.codedata = btScanLib_X.ScanDataCodeData;

			//Get ScanReport property
			objScan.keta = btScanLib_X.ScanReport_Keta;
			objScan.codetype = btScanLib_X.ScanReport_Codetype;
			objScan.composite = btScanLib_X.ScanReport_Composite;
			objScan.quality = btScanLib_X.ScanReport_Quality;
			objScan.extratype = btScanLib_X.ScanReport_Extratype;
			objScan.codelink = btScanLib_X.ScanReport_Codelink;

			//Get QrReport property
			objQr.pos = btScanLib_X.QrReport_Pos;
			objQr.parity = btScanLib_X.QrReport_Parity;
			objQr.count = btScanLib_X.QrReport_Count;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get reading code size (batch)]
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetStringSize = function()
	{
		return btScanLib_X.btScanGetStringSize();	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get reading result (batch)]
	// * @n
	// * @param	[out]	objCode		:Code strings (ScanStringCodeData class)
	// * @param	[out]	objSymbol	:Code type (ScanStringSymbol class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetString = function( objCode, objSymbol )
	{
		var ret = btScanLib_X.btScanGetString();			//Execute ActiveX method
		if (ret == Bt.LibDef.BT_OK){
			objCode.codedata = btScanLib_X.ScanStringCodeData;		//Get Code strings property
			objSymbol.symbol = btScanLib_X.ScanStringSymbol;		//Get Code type property
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get OCR reading result]
	// * @n
	// * @param	[out]	 objOcr	:Code detail information (BT_SCAN_OCR_REPORT class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRData = function( objOcr )
	{
		var ret = btScanLib_X.btScanGetOCRData();	//Execute ActiveX method
		if (ret == Bt.LibDef.BT_OK){
			objOcr.DataFormat = btScanLib_X.ScanOcrReport_Pattern;
			objOcr.AlertType = btScanLib_X.ScanOcrReport_AlertInfo;
			objOcr.FormatNumber = btScanLib_X.ScanOcrReport_FormatNumber;
			objOcr.SourceDataLen = btScanLib_X.ScanOcrReport_DataLen;
			objOcr.SourceData = btScanLib_X.ScanOcrReport_Data;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get character attention of reading result (for OCR)]
	// * @n
	// * @param	[in]	index	:Character index(0~)
	// * @param	[out]	obj	:Character attention class (ScanOcrAttention class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRAttentionEach = function( index, obj )
	{
		var ret = btScanLib_X.btScanGetOCRAttentionEach( index );	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.value = btScanLib_X.ScanOcrReport_Attention;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get OCR reading result]  # Passport recognition
	// * @n
	// * @param	[out]	 objOcr			:Code detail information (BT_SCAN_OCR_REPORT class)
	// * @param	[out]	 objPassport	:Passport detail information (BT_SCAN_OCR_REPORT_PASSPORT class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRData2 = function( objOcr, objPassport )
	{
		var ret = btScanLib_X.btScanGetOCRData2();	//Execute ActiveX method
		if (ret == Bt.LibDef.BT_OK){
			objOcr.DataFormat = btScanLib_X.ScanOcrReport_Pattern;
			objOcr.AlertType = btScanLib_X.ScanOcrReport_AlertInfo;
			objOcr.FormatNumber = btScanLib_X.ScanOcrReport_FormatNumber;
			objOcr.SourceDataLen = btScanLib_X.ScanOcrReport_DataLen;
			objOcr.SourceData = btScanLib_X.ScanOcrReport_Data;

			objPassport.discretionOfIssuingState = btScanLib_X.ScanOcrReportPassport_discretionOfIssuingState;
			objPassport.issuingState = btScanLib_X.ScanOcrReportPassport_issuingState;
			objPassport.fullName = btScanLib_X.ScanOcrReportPassport_fullName;
			objPassport.nameTruncated = btScanLib_X.ScanOcrReportPassport_nameTruncated;
			objPassport.passportNumber = btScanLib_X.ScanOcrReportPassport_passportNumber;
			objPassport.nationality = btScanLib_X.ScanOcrReportPassport_nationality;
			objPassport.yearOfBirth = btScanLib_X.ScanOcrReportPassport_yearOfBirth;
			objPassport.monthOfBirth = btScanLib_X.ScanOcrReportPassport_monthOfBirth;
			objPassport.dayOfBirth = btScanLib_X.ScanOcrReportPassport_dayOfBirth;
			objPassport.sex = btScanLib_X.ScanOcrReportPassport_sex;
			objPassport.yearOfExpiry = btScanLib_X.ScanOcrReportPassport_yearOfExpiry;
			objPassport.monthOfExpiry = btScanLib_X.ScanOcrReportPassport_monthOfExpiry;
			objPassport.dayOfExpiry = btScanLib_X.ScanOcrReportPassport_dayOfExpiry;
			objPassport.optionalData = btScanLib_X.ScanOcrReportPassport_optionalData;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get character attention of reading result (for OCR)]  # Passport recognition
	// * @n
	// * @param	[in]	index	:Character index(0~)
	// * @param	[out]	obj	:Character attention class (ScanOcrAttention class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRAttentionEach2 = function( index, obj )
	{
		var ret = btScanLib_X.btScanGetOCRAttentionEach2( index );	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.value = btScanLib_X.ScanOcrReport_Attention;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get OCR reading result]
	// * @n
	// * @param	[out]	 objOcr	:Code detail information (BT_SCAN_OCR_REPORT_MULTI_STR class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRDataMultiStr = function( objOcr )
	{
		var ret = btScanLib_X.btScanGetOCRDataMultiStr();	//Execute ActiveX method
		if (ret == Bt.LibDef.BT_OK){
			objOcr.DataFormat1 = btScanLib_X.ScanOcrReportMultiStr_Pattern1;
			objOcr.DataFormat2 = btScanLib_X.ScanOcrReportMultiStr_Pattern2;
			objOcr.DataFormat3 = btScanLib_X.ScanOcrReportMultiStr_Pattern3;
			objOcr.DataFormat4 = btScanLib_X.ScanOcrReportMultiStr_Pattern4;
			objOcr.FormatNumber1 = btScanLib_X.ScanOcrReportMultiStr_FormatNumber1;
			objOcr.FormatNumber2 = btScanLib_X.ScanOcrReportMultiStr_FormatNumber2;
			objOcr.FormatNumber3 = btScanLib_X.ScanOcrReportMultiStr_FormatNumber3;
			objOcr.FormatNumber4 = btScanLib_X.ScanOcrReportMultiStr_FormatNumber4;
			objOcr.SourceDataLen1 = btScanLib_X.ScanOcrReportMultiStr_SourceLen1;
			objOcr.SourceDataLen2 = btScanLib_X.ScanOcrReportMultiStr_SourceLen2;
			objOcr.SourceDataLen3 = btScanLib_X.ScanOcrReportMultiStr_SourceLen3;
			objOcr.SourceDataLen4 = btScanLib_X.ScanOcrReportMultiStr_SourceLen4;
			objOcr.SourceData1 = btScanLib_X.ScanOcrReportMultiStr_SourceData1;
			objOcr.SourceData2 = btScanLib_X.ScanOcrReportMultiStr_SourceData2;
			objOcr.SourceData3 = btScanLib_X.ScanOcrReportMultiStr_SourceData3;
			objOcr.SourceData4 = btScanLib_X.ScanOcrReportMultiStr_SourceData4;
			objOcr.FormattedDataLen1 = btScanLib_X.ScanOcrReportMultiStr_OutDataLen1;
			objOcr.FormattedDataLen2 = btScanLib_X.ScanOcrReportMultiStr_OutDataLen2;
			objOcr.FormattedDataLen3 = btScanLib_X.ScanOcrReportMultiStr_OutDataLen3;
			objOcr.FormattedDataLen4 = btScanLib_X.ScanOcrReportMultiStr_OutDataLen4;
			objOcr.FormattedData1 = btScanLib_X.ScanOcrReportMultiStr_OutData1;
			objOcr.FormattedData2 = btScanLib_X.ScanOcrReportMultiStr_OutData2;
			objOcr.FormattedData3 = btScanLib_X.ScanOcrReportMultiStr_OutData3;
			objOcr.FormattedData4 = btScanLib_X.ScanOcrReportMultiStr_OutData4;
			objOcr.StringCount = btScanLib_X.ScanOcrReportMultiStr_StrCount;
			objOcr.AlertType = btScanLib_X.ScanOcrReportMultiStr_AlertType;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get character attention of reading result (for OCR)]
	// * @n
	// * @param	[in]	StrIndex	:String index(0~)
	// * @param	[in]	CharIndex	:Character index(0~)
	// * @param	[out]	obj	:Character attention class (ScanOcrAttention class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRDataMultiStrAttentionEach = function( StrIndex, CharIndex, obj )
	{
		var ret = btScanLib_X.btScanGetOCRDataMultiStrAttentionEach( StrIndex, CharIndex );	// Execute ActiveX method

		if (ret == Bt.LibDef.BT_OK){
			obj.value = btScanLib_X.ScanOcrReport_Attention;
		}
		return ret;
	};

	//********************************************************************************
	// * @brief	Function:@n	[Get OCR reading result]
	// * @n
	// * @param	[out]	 objOcr	:Code detail information (BT_SCAN_OCR_REPORT_DATE_CHOICE class)
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Control.btScanGetOCRDateChoice = function( objOcr )
	{
		var ret = btScanLib_X.btScanGetOCRDateChoice();	//Execute ActiveX method
		if (ret == Bt.LibDef.BT_OK){
			objOcr.OutDateFormat = btScanLib_X.ScanOcrReportDateChoice_OutDateFormat;
			objOcr.OutDateDelim = btScanLib_X.ScanOcrReportDateChoice_OutDateDelim;
			objOcr.valid1 = btScanLib_X.ScanOcrReportDateChoice_valid1;
			objOcr.valid2 = btScanLib_X.ScanOcrReportDateChoice_valid2;
			objOcr.valid3 = btScanLib_X.ScanOcrReportDateChoice_valid3;
			objOcr.date1 = btScanLib_X.ScanOcrReportDateChoice_date1;
			objOcr.date2 = btScanLib_X.ScanOcrReportDateChoice_date2;
			objOcr.date3 = btScanLib_X.ScanOcrReportDateChoice_date3;
			objOcr.year1 = btScanLib_X.ScanOcrReportDateChoice_year1;
			objOcr.year2 = btScanLib_X.ScanOcrReportDateChoice_year2;
			objOcr.year3 = btScanLib_X.ScanOcrReportDateChoice_year3;
			objOcr.month1 = btScanLib_X.ScanOcrReportDateChoice_month1;
			objOcr.month2 = btScanLib_X.ScanOcrReportDateChoice_month2;
			objOcr.month3 = btScanLib_X.ScanOcrReportDateChoice_month3;
			objOcr.day1 = btScanLib_X.ScanOcrReportDateChoice_day1;
			objOcr.day2 = btScanLib_X.ScanOcrReportDateChoice_day2;
			objOcr.day3 = btScanLib_X.ScanOcrReportDateChoice_day3;
		}
		return ret;
	};

	//------------------------------------------------------------------------
	// Bt.ScanLib.Utility
	//------------------------------------------------------------------------
	//********************************************************************************
	// * @brief	Function:@n	[Check code integrity]
	// * @n
	// * @param	[in]		symbol		:Code type
	// * @param	[in]		codeData	:Code strings
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Utility.btScanCheckCode = function( symbol, codeData )
	{
		return btScanLib_X.btScanCheckCode( symbol, codeData );	//Execute ActiveX method
	};

	//********************************************************************************
	// * @brief	Function:@n	[Transfer code strings]
	// * @n
	// * @param	[in]		strPrint	:Data to be transferred
	// * @param	[in]		addKey		:Additional key information
	// * @param	[in]		clipboard	:Transfer to clipboard ON/OFF
	// * @n
	// * @return	Refer to the terminal library reference
	//*********************************************************************************
	ScanLib.Utility.btScanPrintString = function( strPrint, addKey, clipboard )
	{
		return btScanLib_X.btScanPrintString( strPrint, addKey, clipboard );	//Execute ActiveX method
	};

})();

