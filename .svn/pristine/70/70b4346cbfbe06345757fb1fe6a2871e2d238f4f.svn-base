using TMAVerify.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace TMAVerify.Controllers
{
    public class EndUseCartController : Controller
    {
		private DbBusiness _dbBusiness = new DbBusiness();

		private string _result = "NG";

		private string _description = "";

		public ActionResult Index()
		{
			_dbBusiness.SetConnectionString();
			return View();
		}

		[ActionName("End_Use_Cart")]
		public ActionResult End_Use_Cart(string operatorId, string ef)
		{
			ef = ef.Replace("ZZZ", "###");
			_result = "NG";
			_description = "";
			if (WriteToData(operatorId, ef))
			{
				_result = "OK";
			}
			return Content(_result + "#" + _description);
		}
		private bool DeleteBOSSEfuRelation(string ef)
        {
			bool result = false;
			string query = @"Select * from Z_PARTINVINFOBYCARTNO where CARTNUMBER = '" + ef + "'";
			DataTable relationEfudtb = DbHelperBOSS.GetData(query);
			if(relationEfudtb.Rows.Count > 0)
            {
				string[] queryList = new string[2];
				string cartID = relationEfudtb.Rows[0]["CARTID"].ToString().Trim();
				string query1 = @"Delete from Z_PARTINVINFOBYCARTNO where CARTNUMBER = '" + ef + "'";
				// Gay ra loi Carry Order information is not found!
				//string query2 = @"Delete from Z_PARTINVINFOBYCARTID where CARTID = '" + cartID + "'";
                try
                {					
					queryList[0] = query1;
					//queryList[1] = query2;
					DbHelperBOSS.ExecuteQueryUsingTran(queryList);
				}
                catch
                {
					result = DbHelperBOSS.Error;
                }
			}
			return result;
        }
		private bool WriteToData(string operatorId, string ef)
		{
			bool result = false;
			double d = 0.0;
			int typeTMA = 0;
			if (ef.StartsWith("21") || ef.StartsWith("22") || ef.StartsWith("23") || ef.StartsWith("24") || ef.StartsWith("25"))
			{
				DataTable dtbLinkage = _dbBusiness.VerifyPhysicalPalletHistoryBOSS(ef);
				if (dtbLinkage.Rows.Count > 0 && _dbBusiness.EndUseMixing(dtbLinkage.Rows[0]["PALETTENO"].ToString(), ef, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), operatorId, 1, 7, "FREE", "Giai phong FIFO khi End Use", endUse: true))
				{
					result = true;
					_description = _description + "EndUse " + ef + " thanh cong" + Environment.NewLine;
				}
				else
				{
					_description = _description + "EndUse " + ef + " that bai" + Environment.NewLine;
				}
			}
			else if (ef.StartsWith("MV1"))
			{
				if (ef.Length > 10)
				{
					string cartNumber = ef.Substring(3, 10);
					if (ef.StartsWith("MV1A1") || ef.StartsWith("MV1A2") || ef.StartsWith("MV1A3"))
					{
						DataTable dtbLinkage2 = _dbBusiness.VerifyPhysicalPalletHistoryBOSS(ef);
						if (dtbLinkage2.Rows.Count > 0 && _dbBusiness.EndUseMixing(dtbLinkage2.Rows[0]["PALETTENO"].ToString(), ef, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), operatorId, 1, 7, "FREE", "Giai phong FIFO khi End Use", endUse: true))
						{
							result = true;
							_description = _description + "EndUse " + ef + " thanh cong" + Environment.NewLine;
						}
						else
						{
							_description = _description + "EndUse " + ef + " that bai" + Environment.NewLine;
						}
					}
					else
					{
						DataTable dtb = _dbBusiness.GetDataMATERIALINVENTORY(cartNumber);
						if (_dbBusiness.UpdateStatusDataOldOfEFUInventory(operatorId, cartNumber, 2, endUse: true))
						{
                            if (!DeleteBOSSEfuRelation(cartNumber))
                            {
								result = true;
								_description = _description + "EndUse " + cartNumber + " thanh cong." + Environment.NewLine;
								_dbBusiness.EndUseMaterial(cartNumber, dtb.Rows[0]["REMAIN"].ToString(), operatorId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
							}
                            else
                            {
								_description = _description + "EndUse " + cartNumber + " thanh cong." + Environment.NewLine + "Loi khong the xoa lien ket FIFO !!!";
								_dbBusiness.EndUseMaterial(cartNumber, dtb.Rows[0]["REMAIN"].ToString(), operatorId + "- E", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
							}
						}
						else
						{
							_description = _description + "EndUse " + cartNumber + " that bai." + Environment.NewLine;
						}
					}
				}
			}
			else if (ef.StartsWith("TMA") || double.TryParse(ef, out d))
			{
				if (ef.StartsWith("TMAExtruding"))
				{
					typeTMA = 1;
					if (_dbBusiness.EndUseTMAEfu(typeTMA, ef, operatorId, 2, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
					{
						result = true;
						_description = _description + "EndUse " + ef + " thanh cong." + Environment.NewLine;
						if (_dbBusiness.DeleteRelationFIFO(ef, operatorId))
						{
							_description += "\n Log data have been saved successfully!";
						}
						else
						{
							_description += "\n Fail to saved log data!";
						}
						_dbBusiness.TMAUsing(ef, "", "", operatorId, _description, "", "OK", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), endUse: true);
					}
					else
					{
						_description = _description + "EndUse " + ef + " that bai." + Environment.NewLine;
					}
				}
				if (ef.StartsWith("TMARemixing"))
				{
					typeTMA = 2;
					if (_dbBusiness.EndUseTMAEfu(typeTMA, ef, operatorId, 2, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
					{
						result = true;
						_description = _description + "EndUse " + ef + " thanh cong." + Environment.NewLine;
						if (_dbBusiness.DeleteRelationFIFO(ef, operatorId))
						{
							_description += "\n Log data have been saved successfully!";
						}
						else
						{
							_description += "\n Fail to saved log data!";
						}
						_dbBusiness.TMAUsing(ef, "", "", operatorId, _description, "", "OK", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), endUse: true);
					}
					else
					{
						_description = _description + "EndUse " + ef + " that bai." + Environment.NewLine;
					}
				}
			}
			return result;
		}
	}
}