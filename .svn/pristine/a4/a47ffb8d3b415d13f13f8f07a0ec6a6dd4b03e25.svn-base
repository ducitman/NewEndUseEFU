using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TMAVerify.Models
{
    public class DbBusiness
    {
		public void SetConnectionString()
		{
			string oraBOSSConnectionString = ConfigurationManager.ConnectionStrings["BOSSDB"].ConnectionString;
			string sqlTMADBConnectionString = ConfigurationManager.ConnectionStrings["TMADB"].ConnectionString;
			DbHelperBOSS.ConnectionString = oraBOSSConnectionString;
			DbHelperTMADB.ConnectionString = sqlTMADBConnectionString;
		}

		public bool CheckAuthorization(string opCode, string programName, string functionName)
		{
			string query = "SELECT Z_USERAUTHORITY.LOGINUSERNAME\r\n                                FROM Z_USERAUTHORITY LEFT JOIN \r\n                                     Z_PROGRAMFUNCTIONAUTHORITY ON Z_USERAUTHORITY.AUTHORITYGROUP = Z_PROGRAMFUNCTIONAUTHORITY.AUTHORITYGROUP\r\n                                WHERE Z_USERAUTHORITY.LOGINUSERNAME = '" + opCode + "' AND Z_PROGRAMFUNCTIONAUTHORITY.PROGRAMNAME = '" + programName + "' AND Z_PROGRAMFUNCTIONAUTHORITY.FUNCTIONNAME = '" + functionName + "'";
			return DbHelperBOSS.CheckData(query);
		}

		public DataTable VerifyBlueMemo(string bluememo, string ef)
		{
			string query = "SELECT MemoProcessing.ApproveDate FROM MTRL_BlueMemo.dbo.MemoCart INNER JOIN MTRL_BlueMemo.dbo.MemoProcessing ON MemoCart.MemoRegisterID = MemoProcessing.MemoRegisterID WHERE Section = 'PM' AND MemoCart.MemoRegisterID = N'" + bluememo + "' AND UPPER(CartNo) = N'" + ef.ToUpper() + "'";
			return DbHelperTMADB.GetData(query);
		}

		public bool CheckCart(string cartID)
		{
			string query = "SELECT CARTID FROM Z_CARTIDMASTER WHERE CARTID = '" + cartID + "'";
			return DbHelperBOSS.CheckExist(query);
		}

		public bool ScaleCart(string operatorId, string cartID, string weight, string scaleDate)
		{
			string query = "";
			query = query + "IF NOT EXISTS (SELECT CartID FROM BTMVLocalApps.dbo.COM_MaterialCartWeight WHERE CartID = N'" + cartID + "') BEGIN INSERT INTO BTMVLocalApps.dbo.COM_MaterialCartWeight(CartID, Weight, Comment, UpdateUser, UpdatedTime) VALUES (N'" + cartID + "', N'" + weight + "', N'', N'" + operatorId + "', N'" + scaleDate + "') END ELSE BEGIN UPDATE BTMVLocalApps.dbo.COM_MaterialCartWeight SET Weight = N'" + weight + "', UpdatedTime = N'" + scaleDate + "', UpdateUser = N'" + operatorId + "' WHERE CartID = '" + cartID + "' END;";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public bool CheckTMACart(string cartNo)
		{
			string query = "SELECT Cart_name FROM TMACART WHERE Cart_name = N'" + cartNo + "'";
			return DbHelperTMADB.CheckData(query);
		}

		public bool CheckPallet(string palletNo)
		{
			string query = "SELECT PALETTENO FROM Z_GUMPALETTEMASTER WHERE PALETTENO = '" + palletNo + "'";
			return DbHelperBOSS.CheckExist(query);
		}

		public DataTable CheckStatusOfOldEFUNoUse(string ef)
		{
			string query = "SELECT EFU FROM TMAINVENTORY WHERE Barcode = N'" + ef + "' AND CartStatus = 0";
			return DbHelperTMADB.GetData(query);
		}

		public string GetOldTMAEFUOfCart(string cartNo)
		{
			string query = "SELECT TMAEFU FROM TMA_REGIST_CART WHERE TMACardName = N'" + cartNo + "'";
			DataTable tbl = DbHelperTMADB.GetData(query);
			if (tbl.Rows.Count <= 0)
			{
				return "";
			}
			return tbl.Rows[0][0].ToString();
		}

		public bool UpdateStatusDataOldOfEFUStockGumData(string operatorId, string ef, int status, bool endUse)
		{
			string query = "UPDATE BBQA.STOCKGUMDATA SET STATUS = '" + status + "' " + (endUse ? ", REMAIN = '-999'" : "") + " WHERE BARCODE = '" + ef + "'";
			DbHelperBOSS.ExecuteQueryUsingTran(query);
			return !DbHelperBOSS.Error;
		}

		public bool UpdateStatusDataOldOfEFUInventory(string operatorId, string cartNumber, int status, bool endUse)
		{
			string query = "UPDATE Z_MATERIALINVENTORY SET CARTSTATUS = '" + status + "' " + (endUse ? ", REMAIN = '-999'" : "") + " WHERE CARTNUMBER = '" + cartNumber + "'";
			DbHelperBOSS.ExecuteQueryUsingTran(query);
			return !DbHelperBOSS.Error;
		}

		public bool UpdateStatusDataOldOfEFUSheetData(string operatorId, string cartNumber, int status, bool endUse)
		{
			string query = "UPDATE Z_SLITSHEETDATA SET STATUS = '" + status + "' " + (endUse ? ", REMAIN = '-999'" : "") + " WHERE CARTNUMBER = '" + cartNumber + "'";
			DbHelperBOSS.ExecuteQueryUsingTran(query);
			return !DbHelperBOSS.Error;
		}

		public string checksttTMA(int type, string ef)
		{
			string stt = "";
			if (type == 1)
			{
				string sql = "SELECT OperatorEndUseCart,EndUse_Date FROM [MTRL_TMADB].[dbo].[TMA_EXTRUDING] WHERE Barcode = '" + ef + "';";
				DataTable tbl = DbHelperTMADB.GetData(sql);
				if (tbl.Rows.Count == 0)
				{
					stt = "Khong tim thay the nguyen lieu nay";
				}
				else if (tbl.Rows[0]["OperatorEndUseCart"].ToString() == "" && tbl.Rows[0]["EndUse_Date"].ToString() == "")
				{
					stt = "OK";
				}
			}
			else
			{
				string sql2 = "SELECT OperatorEndUseCart,EndUse_Date FROM TMAINVENTORY WHERE Barcode = '" + ef + "';";
				DataTable tbl2 = DbHelperTMADB.GetData(sql2);
				if (tbl2.Rows.Count == 0)
				{
					stt = "Khong tim thay the nguyen lieu nay";
				}
				else if (tbl2.Rows[0]["OperatorEndUseCart"].ToString() == "" && tbl2.Rows[0]["EndUse_Date"].ToString() == "")
				{
					stt = "OK";
				}
			}
			return stt;
		}

		public bool EndUseTMAEfu(int type, string ef, string operatorId, int status, string endUseDate)
		{
			bool stt = false;
			if (type == 1 && checksttTMA(1, ef) == "OK")
			{
				string query2 = "UPDATE TMA_EXTRUDING SET CartStatus = N'" + status + "', OperatorEndUseCart = N'" + operatorId + "', EndUse_Date = N'" + endUseDate + "' WHERE Barcode = N'" + ef + "';";
				DbHelperTMADB.ExecuteQueryUsingTran(query2);
				stt = true;
			}
			if (type == 2 && checksttTMA(2, ef) == "OK")
			{
				string query = "UPDATE TMAINVENTORY SET CartStatus = N'" + status + "', OperatorEndUseCart = N'" + operatorId + "', EndUse_Date = N'" + endUseDate + "' WHERE Barcode = N'" + ef + "';";
				DbHelperTMADB.ExecuteQueryUsingTran(query);
				stt = true;
			}
			return stt;
		}

		public bool RegisterCartTMARemixing(string operatorId, string cartNo, string ef, string registDate, string description, string efuOldOfCart, int actionType, int registerFlag)
		{
			string query = "";
			if (efuOldOfCart != "")
			{
				query = query + "UPDATE TMAINVENTORY SET CartStatus = N'2' WHERE Barcode = '" + efuOldOfCart + "' AND CartStatus != 0;";
			}
			query = query + "IF EXISTS (SELECT TMAEFU FROM TMA_REGIST_CART WHERE TMAEFU = '" + ef + "') BEGIN UPDATE TMA_REGIST_CART SET TMAEFU = N'' WHERE TMAEFU = '" + ef + "' END;";
			query = query + "IF NOT EXISTS (SELECT TMACardName FROM TMA_REGIST_CART WHERE TMACardName = '" + cartNo + "') BEGIN INSERT INTO TMA_REGIST_CART(TMACardName, TMAEFU, RegistDate, RegistUser) VALUES (N'" + cartNo + "', N'" + ef + "', N'" + registDate + "', N'" + operatorId + "') END ELSE BEGIN UPDATE TMA_REGIST_CART SET TMAEFU = N'" + ef + "', RegistDate = N'" + registDate + "', RegistUser = N'" + operatorId + "' WHERE TMACardName = '" + cartNo + "' END;";
			query = query + "INSERT INTO TMA_REGIST_CART_HISTORY(TMACardName, TMAEFU, RegistDate, RegistUser, [Description], ActionType, RegisterFlag, Address) VALUES(N'" + cartNo + "', N'" + ef + "', N'" + registDate + "', N'" + operatorId + "', N'" + description + "', '" + actionType + "', '" + registerFlag + "', '');";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public bool RegisterCartTMAExtruding(string operatorId, string palletNo, string ef, string registDate, string description, int actionType, int registerFlag)
		{
			string query = "";
			query = query + "IF EXISTS (SELECT TMAEFU FROM TMA_REGIST_PALLET WHERE TMAEFU = '" + ef + "') BEGIN UPDATE TMA_REGIST_PALLET SET TMAEFU = N'' WHERE TMAEFU = '" + ef + "' END;";
			query = query + "IF NOT EXISTS (SELECT TMAPalletNo FROM TMA_REGIST_PALLET WHERE TMAPalletNo = '" + palletNo + "') BEGIN INSERT INTO TMA_REGIST_PALLET(TMAPalletNo, TMAEFU, RegistDate, RegistUser) VALUES (N'" + palletNo + "', N'" + ef + "', N'" + registDate + "', N'" + operatorId + "') END ELSE BEGIN UPDATE TMA_REGIST_PALLET SET TMAEFU = N'" + ef + "', RegistDate = N'" + registDate + "', RegistUser = N'" + operatorId + "' WHERE TMAPalletNo = '" + palletNo + "' END;";
			query = query + "INSERT INTO TMA_REGIST_PALLET_HISTORY(TMAPalletNo, TMAEFU, RegistDate, RegistUser, [Description], ActionType, RegisterFlag, Address) VALUES(N'" + palletNo + "', N'" + ef + "', N'" + registDate + "', N'" + operatorId + "', N'" + description + "', '" + actionType + "', '" + registerFlag + "', '');";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public bool RegisterCartHistoryTMARemixing(string operatorId, string cartNo, string ef, string registDate, string description, int actionType, int registerFlag)
		{
			string query = "INSERT INTO TMA_REGIST_CART_HISTORY(TMACardName, TMAEFU, RegistDate, RegistUser, [Description], ActionType, RegisterFlag) VALUES(N'" + cartNo + "', N'" + ef + "', N'" + registDate + "', N'" + operatorId + "', N'" + description + "', '" + actionType + "', '" + registerFlag + "');";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public bool RegisterCartHistoryTMAExtruding(string operatorId, string palletNo, string ef, string registDate, string description, int actionType, int registerFlag)
		{
			string query = "INSERT INTO TMA_REGIST_PALLET_HISTORY(TMAPalletNo, TMAEFU, RegistDate, RegistUser, [Description], ActionType, RegisterFlag) VALUES(N'" + palletNo + "', N'" + ef + "', N'" + registDate + "', N'" + operatorId + "', N'" + description + "', '" + actionType + "', '" + registerFlag + "');";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public DataTable GetMaterialScheduleLot(string placeID, string machineNo)
		{
			string query = "";
			query = ((int.Parse(placeID.Trim()) != 71 && int.Parse(placeID.Trim()) != 72) ? ("\r\n                        SELECT FIELDDATA, C.MATERIALLOTNUMBER, C.MACHINENAMESHORT \r\n                        FROM \r\n                            SPEC.Z_SPECMTRLMASTER D INNER JOIN\r\n                            (SELECT \r\n                                A.FIELDID, B.PARTNUMBER, B.PROCESSNO, B.MATERIALLOTNUMBER, C.MACHINEGROUP, TRIM(REPLACE(C.MACHINENAMESHORT, ' ', '')) AS MACHINENAMESHORT \r\n                            FROM Z_FAMATERIALVERIFYPLACEMASTER A INNER JOIN \r\n                                Z_MATERIALSCHEDULELOT B ON A.UPPERPARTID = B.PARTID INNER JOIN \r\n                                Z_MATERIALMACHINEMASTER C ON B.ACTUALMACHINEID = C.MACHINEID \r\n                            WHERE B.ACTUALMACHINEID = '" + machineNo + "' AND B.STATUSFLAG = '1' AND A.PLACENO = '" + placeID + "'\r\n                            ) C ON D.MACHINEGROUP = C.MACHINEGROUP AND D.PARTNUMBER = C.PARTNUMBER AND D.FIELDID = C.FIELDID AND D.REVISIONNO = C.PROCESSNO \r\n                        ORDER BY D.FIELDDATA") : ("\r\n                        SELECT FIELDDATA, C.MATERIALLOTNUMBER, C.MACHINENAMESHORT \r\n                        FROM \r\n                            SPEC.Z_SPECMTRLMASTER D INNER JOIN\r\n                            (SELECT \r\n                                A.FIELDID, B.PARTNUMBER, B.PROCESSNO, B.MATERIALLOTNUMBER, C.MACHINEGROUP, TRIM(REPLACE(C.MACHINENAMESHORT, ' ', '')) AS MACHINENAMESHORT \r\n                            FROM Z_FAMATERIALVERIFYPLACEMASTER A INNER JOIN \r\n                                Z_MATERIALSCHEDULELOT B ON A.UPPERPARTID = B.PARTID INNER JOIN \r\n                                Z_MATERIALMACHINEMASTER C ON B.ACTUALMACHINEID = C.MACHINEID \r\n                            WHERE B.ACTUALMACHINEID = '" + machineNo + "' AND B.STATUSFLAG = '1' AND A.PLACENO = '7'\r\n                            ) C ON D.MACHINEGROUP = C.MACHINEGROUP AND D.PARTNUMBER = C.PARTNUMBER AND D.FIELDID = C.FIELDID AND D.REVISIONNO = C.PROCESSNO \r\n                        ORDER BY D.FIELDDATA"));
			return DbHelperBOSS.GetData(query);
		}

		public DataTable GetTMAInventory(string ef)
		{
			string query = "SELECT TMACartNo, Cart_name, TMA_Name, Thickness, CartStatus, Age_Limit - DATEDIFF(DAY, Extrud_date, '" + DateTime.Now.ToString("yyyy-MM-dd") + "') AS ExpiryDate FROM TMAINVENTORY INNER JOIN TMACART ON TMAINVENTORY.TMACartNo = TMACART.Cart_ID WHERE Barcode = N'" + ef + "'";
			return DbHelperTMADB.GetData(query);
		}

		public DataTable GetTMAExtruding(string ef)
		{
			string query = "SELECT Barcode, TMAName, PalletNo FROM TMA_EXTRUDING WHERE Barcode = N'" + ef + "'";
			return DbHelperTMADB.GetData(query);
		}

		public int GetNumOfStrips(string caoSuTMA, string doDaiCaoSu, string caoSuDangSanXuat)
		{
			string query = "select Num_Of_Strips from TMA_DATA where TMA_name = '" + caoSuTMA + "' and Spec_Feed_Shape = '" + doDaiCaoSu + "' and  ARAKIJI_ID = (Select ID from ARAKIJI where Name = '" + caoSuDangSanXuat + "' and Approve = '1') and Approve = '1'";
			DataTable tbl = DbHelperTMADB.GetData(query);
			if (tbl.Rows.Count <= 0)
			{
				return 0;
			}
			return int.Parse(tbl.Rows[0]["Num_Of_Strips"].ToString());
		}

		public DataTable GetDataVerifiedLatest(string placeNo, string materialLOT)
		{
			string query = "";
			if (placeNo == "71")
			{
				query = "SELECT TOP 1 TMAINVENTORY.TMA_Name, TMAINVENTORY.Thickness FROM TMAUSING INNER JOIN TMAINVENTORY ON TMAUSING.Barcode = TMAINVENTORY.Barcode WHERE TMAUSING.Result = 'OK' AND TMAUSING.User_Lot = '" + materialLOT + "' AND TMAUSING.Verify_place LIKE '%-72-%' AND TMAUSING.Verify_Date >= '" + DateTime.Now.AddMonths(-11).ToString("yyyy-MM-dd") + "' ORDER BY TMAUSING.Verify_Date DESC";
			}
			else if (placeNo == "72")
			{
				query = "SELECT TOP 1 TMAINVENTORY.TMA_Name, TMAINVENTORY.Thickness FROM TMAUSING INNER JOIN TMAINVENTORY ON TMAUSING.Barcode = TMAINVENTORY.Barcode WHERE TMAUSING.Result = 'OK' AND TMAUSING.User_Lot = '" + materialLOT + "' AND TMAUSING.Verify_place LIKE '%-71-%' AND TMAUSING.Verify_Date >= '" + DateTime.Now.AddMonths(-11).ToString("yyyy-MM-dd") + "' ORDER BY TMAUSING.Verify_Date DESC";
			}
			return DbHelperTMADB.GetData(query);
		}

		public bool VerifyPhysicalCart(string cartNo, string ef)
		{
			string query = "SELECT TMAEFU FROM TMA_REGIST_CART WHERE TMACardName = N'" + cartNo + "' AND TMAEFU = N'" + ef + "'";
			return DbHelperTMADB.CheckData(query);
		}

		public bool VerifyPhysicalPalletTMAExtruding(string palletNo, string ef)
		{
			string query = "SELECT TMAEFU FROM TMA_REGIST_PALLET WHERE TMAPalletNo = N'" + palletNo + "' AND TMAEFU = N'" + ef + "'";
			return DbHelperTMADB.CheckData(query);
		}

		public bool VerifyCompareTMA(string caoSuTMASuDung, string doDaiCaoSu, string caoSuDangSanXuat)
		{
			string query = "SELECT TMA_name FROM TMA_DATA WHERE TMA_name = N'" + caoSuTMASuDung + "' AND Spec_Feed_Shape = N'" + doDaiCaoSu + "' AND ARAKIJI_ID IN (SELECT ID FROM ARAKIJI WHERE Name = N'" + caoSuDangSanXuat + "' AND Approve = '1') AND Approve = '1'";
			return DbHelperTMADB.CheckData(query);
		}

		public bool VerifyDoubleTMA(string ef, string materialLotNumber)
		{
			string query = "SELECT Barcode FROM TMAUSING WHERE Barcode = N'" + ef + "' AND User_Lot = N'" + materialLotNumber + "' AND Result = N'OK'";
			return DbHelperTMADB.CheckData(query);
		}

		public bool TMAUsing(string ef, string verifyPlace, string materialLotNumber, string operatorId, string description, string machineNo, string verifyResult, string verifyDate, bool endUse)
		{
			string query = "";
			if (verifyResult == "OK")
			{
				string lastPlace = "";
				if (!endUse)
				{
					lastPlace = ", Verify_Place = N'" + verifyPlace + "', LastVerifyPlace = N'" + verifyPlace + "'";
				}
				query = query + "UPDATE TMAINVENTORY SET CartStatus = N'1' WHERE Barcode = N'" + ef + "' AND CartStatus <> N'2';";
				query = query + "UPDATE TMAINVENTORY SET User_Lot = N'" + materialLotNumber + "', Verify_Date = N'" + verifyDate + "', Verify_count = Verify_count + 1 " + lastPlace + " WHERE Barcode = N'" + ef + "';";
			}
			query = query + "INSERT INTO TMAUSING(Barcode, Verify_Place, Verify_Count, User_Lot, Verify_Date, Operator, Result, [Description], MC_Using) VALUES(N'" + ef + "', N'" + verifyPlace + "', '1', N'" + materialLotNumber + "', N'" + verifyDate + "', N'" + operatorId + "', N'" + verifyResult + "', N'" + description + "', N'" + machineNo + "');";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public bool WriteLogToTMADB(string ef, string CartNo, string TMAEFU, string RegisterDate, string RegisterUser, string AddressFIFO, string FIFODate, string FIFOUser, string OPCode)
		{
			string query = "Insert into DELETE_RELATION_FIFO_LOG (TMACartNo,TMAEFU,RegistDate,RegisterUser,AddressFIFO,FIFODate,FIFOUser,DeleteTime,OPCode) values ('" + CartNo + "','" + ef + "','" + RegisterDate + "','" + RegisterUser + "','" + AddressFIFO + "','" + FIFODate + "','" + FIFOUser + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + OPCode + "')";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public bool DeleteRelationFIFO(string ef, string OPCode)
		{
			string query = "";
			DataTable tbl = new DataTable();
			if (ef.StartsWith("TMARemixing"))
			{
				query = "Delete from TMA_REGIST_CART where TMAEFU = '" + ef + "'";
				tbl = DbHelperTMADB.GetData("Select * from TMA_REGIST_CART where TMAEFU = '" + ef + "'");
				DbHelperTMADB.ExecuteQueryUsingTran(query);
				WriteLogToTMADB(ef, tbl.Rows[0]["TMACardName"].ToString().Trim(), tbl.Rows[0]["TMAEFU"].ToString().Trim(), tbl.Rows[0]["RegistDate"].ToString().Trim(), tbl.Rows[0]["RegistUser"].ToString().Trim(), tbl.Rows[0]["Address"].ToString().Trim(), tbl.Rows[0]["FIFODate"].ToString().Trim(), tbl.Rows[0]["FIFOUser"].ToString().Trim(), OPCode);
			}
			if (ef.StartsWith("TMAExtruding"))
			{
				query = "Delete from TMA_REGIST_PALLET where TMAEFU = '" + ef + "'";
				tbl = DbHelperTMADB.GetData("Select * from TMA_REGIST_PALLET where TMAEFU = '" + ef + "'");
				DbHelperTMADB.ExecuteQueryUsingTran(query);
				WriteLogToTMADB(ef, tbl.Rows[0]["TMAPalletNo"].ToString().Trim(), tbl.Rows[0]["TMAEFU"].ToString().Trim(), tbl.Rows[0]["RegistDate"].ToString().Trim(), tbl.Rows[0]["RegistUser"].ToString().Trim(), tbl.Rows[0]["Address"].ToString().Trim(), tbl.Rows[0]["FIFODate"].ToString().Trim(), tbl.Rows[0]["FIFOUser"].ToString().Trim(), OPCode);
			}
			return !DbHelperTMADB.Error;
		}

		public DataTable VerifyPhysicalPalletHistoryBOSS(string ef)
		{
			string query = "";
			if (ef.StartsWith("MV1A1") || ef.StartsWith("MV1A2") || ef.StartsWith("MV1A3"))
			{
				ef = ((ef.Length >= 13) ? ef.Substring(3, 10) : "");
			}
			query = "SELECT PALETTENO, GUMEFBARCODE FROM Z_GUMPALETTEINVRELATIONHISTORY WHERE GUMEFBARCODE = '" + ef + "' AND ACTIONTYPE = '1' AND REGISTDATE >= TO_DATE('" + DateTime.Now.AddMonths(-11).ToString("yyyy-MM-dd HH:mm:ss") + "','YYYY-MM-DD HH24:MI:SS') ORDER BY REGISTDATE DESC";
			return DbHelperBOSS.GetData(query);
		}

		public bool EndUseMixing(string pallet, string ef, string registDate, string operatorId, int actionType, int registerFlag, string address, string description, bool endUse)
		{
			string[] query = new string[3];
			if (ef.StartsWith("11") || ef.StartsWith("12") || ef.StartsWith("13") || ef.StartsWith("14"))
			{
				query[0] = "UPDATE BBQA.STOCKCOMPOUNDDATA SET STATUS = '2'" + (endUse ? ", REMAIN = '-999'" : "") + " WHERE TRIM(BARCODE) = '" + ef + "'";
			}
			else if (ef.StartsWith("MV1A1") || ef.StartsWith("MV1A2") || ef.StartsWith("MV1A3"))
			{
				ef = ((ef.Length >= 13) ? ef.Substring(3, 10) : "");
				query[0] = "UPDATE Z_SLITSHEETDATA SET STATUS = '2'" + (endUse ? ", REMAIN = '-999'" : "") + " WHERE TRIM(CARTNUMBER) = '" + ef + "'";
			}
			else
			{
				query[0] = "UPDATE BBQA.STOCKGUMDATA SET STATUS = '2'" + (endUse ? ", REMAIN = '-999'" : "") + " WHERE TRIM(BARCODE) = '" + ef + "'";
			}
			query[1] = "DELETE FROM Z_GUMPALETTEINVRELATION WHERE GUMEFBARCODE = '" + ef + "'";
			query[2] = "INSERT INTO Z_GUMPALETTEINVRELATIONHISTORY(PALETTENO, GUMEFBARCODE, REGISTDATE, REGISTUSER, ACTIONTYPE, REGISTFLAG, ADDRESS, DESCRIPTION) \r\n                                VALUES('" + pallet + "','" + ef + "',TO_DATE('" + registDate + "','YYYY-MM-DD HH24:MI:SS'),'" + operatorId + "','" + actionType + "','" + registerFlag + "','" + address + "','" + description + "') ";
			DbHelperBOSS.ExecuteQueryUsingTran(query);
			return !DbHelperBOSS.Error;
		}

		public bool EndUseMaterial(string ef, string remain, string operatorId, string verifyDate)
		{
			string query = "INSERT INTO MTRL_CheckingInventory.dbo.MI_MaintenanceLog(CartNumber, MaterialName, Parameter, OldData, NewData, ComputerName, DateChange, Process) VALUES(N'" + ef + "', N'" + operatorId + "', N'remain', N'" + remain + "', N'-999', N'" + operatorId + "', N'" + verifyDate + "', N'EndUseMaterialCartPro1');";
			DbHelperTMADB.ExecuteQueryUsingTran(query);
			return !DbHelperTMADB.Error;
		}

		public DataTable GetDataMATERIALINVENTORY(string cartNumber)
		{
			string query = "SELECT MACHINEID, DATEPRODUCED AS NGAYSANXUAT, DATEPRODUCED + AGELIMIT / 3 AS NGAYHETHAN, PARTNUMBER, REMAIN, CASE WHEN REMAIN = '-999' THEN 'Da Su Dung Het' ELSE CASE WHEN CARTSTATUS = '0' THEN 'Chua Su Dung' ELSE 'Dang Su Dung' END END AS STATUS FROM Z_MATERIALINVENTORY WHERE TRIM(CARTNUMBER) = '" + cartNumber + "'";
			return DbHelperBOSS.GetData(query);
		}
	}
}