using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x02000751 RID: 1873
	public class MoneyManager : NetworkSingleton<MoneyManager>
	{
		// Token: 0x0600A83F RID: 43071 RVA: 0x002A3940 File Offset: 0x002A1B40
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyManager()
		{
			Il2CppClassPointerStore<MoneyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "MoneyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr);
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR");
			MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "MONEY_TEXT_COLOR_DARKER");
			MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ONLINE_BALANCE_COLOR");
			MoneyManager.NativeFieldInfoPtr_ledger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "ledger");
			MoneyManager.NativeFieldInfoPtr_onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onlineBalance");
			MoneyManager.NativeFieldInfoPtr_lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LastCalculatedNetworth>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_CashSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "CashSound");
			MoneyManager.NativeFieldInfoPtr_moneyChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "moneyChangePrefab");
			MoneyManager.NativeFieldInfoPtr_cashChangePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "cashChangePrefab");
			MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "LaunderingNotificationIcon");
			MoneyManager.NativeFieldInfoPtr_onNetworthCalculation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "onNetworthCalculation");
			MoneyManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "loader");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___onlineBalance");
			MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "syncVar___lifetimeEarnings");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted");
			MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683955);
			MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683956);
			MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683957);
			MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683958);
			MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683959);
			MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683960);
			MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683961);
			MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683962);
			MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683963);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683964);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683965);
			MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683966);
			MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683967);
			MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683968);
			MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683969);
			MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683970);
			MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683971);
			MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683972);
			MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683973);
			MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683974);
			MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683975);
			MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683976);
			MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683977);
			MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683978);
			MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683979);
			MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683980);
			MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683981);
			MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683982);
			MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683983);
			MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683984);
			MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683985);
			MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683986);
			MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683987);
			MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683988);
			MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683989);
			MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683990);
			MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683991);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683992);
			MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683993);
			MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683994);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683995);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683996);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683997);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683998);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100683999);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684000);
			MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684001);
			MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684002);
			MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684003);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684004);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684005);
			MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684006);
			MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684007);
			MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684008);
			MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, 100684009);
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600A840 RID: 43072 RVA: 0x002A3F4C File Offset: 0x002A214C
		public unsafe float LifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61709, RefRangeEnd = 61710, XrefRangeStart = 61709, XrefRangeEnd = 61710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600A841 RID: 43073 RVA: 0x002A3F88 File Offset: 0x002A2188
		// (set) Token: 0x0600A842 RID: 43074 RVA: 0x002A3FC4 File Offset: 0x002A21C4
		public unsafe float LastCalculatedNetworth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600A843 RID: 43075 RVA: 0x002A4004 File Offset: 0x002A2204
		public unsafe float cashBalance
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 293622, RefRangeEnd = 293647, XrefRangeStart = 293621, XrefRangeEnd = 293622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600A844 RID: 43076 RVA: 0x002A4040 File Offset: 0x002A2240
		public unsafe CashInstance cashInstance
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 293651, RefRangeEnd = 293659, XrefRangeStart = 293647, XrefRangeEnd = 293651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x002A4080 File Offset: 0x002A2280
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293659, XrefRangeEnd = 293661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600A846 RID: 43078 RVA: 0x002A40B8 File Offset: 0x002A22B8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293661, XrefRangeEnd = 293663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600A847 RID: 43079 RVA: 0x002A40F0 File Offset: 0x002A22F0
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600A848 RID: 43080 RVA: 0x002A4130 File Offset: 0x002A2330
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600A849 RID: 43081 RVA: 0x002A416C File Offset: 0x002A236C
		// (set) Token: 0x0600A84A RID: 43082 RVA: 0x002A41AC File Offset: 0x002A23AC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600A84B RID: 43083 RVA: 0x002A41F0 File Offset: 0x002A23F0
		// (set) Token: 0x0600A84C RID: 43084 RVA: 0x002A4230 File Offset: 0x002A2430
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90006, RefRangeEnd = 90007, XrefRangeStart = 90006, XrefRangeEnd = 90007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600A84D RID: 43085 RVA: 0x002A4274 File Offset: 0x002A2474
		// (set) Token: 0x0600A84E RID: 43086 RVA: 0x002A42B0 File Offset: 0x002A24B0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A84F RID: 43087 RVA: 0x002A42F0 File Offset: 0x002A24F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293663, XrefRangeEnd = 293666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A850 RID: 43088 RVA: 0x002A432C File Offset: 0x002A252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293666, XrefRangeEnd = 293672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A851 RID: 43089 RVA: 0x002A4368 File Offset: 0x002A2568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293672, XrefRangeEnd = 293724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A852 RID: 43090 RVA: 0x002A43A4 File Offset: 0x002A25A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293724, XrefRangeEnd = 293733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A853 RID: 43091 RVA: 0x002A43E0 File Offset: 0x002A25E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293733, XrefRangeEnd = 293740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A854 RID: 43092 RVA: 0x002A441C File Offset: 0x002A261C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293740, XrefRangeEnd = 293788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A855 RID: 43093 RVA: 0x002A4458 File Offset: 0x002A2658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293788, XrefRangeEnd = 293795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A856 RID: 43094 RVA: 0x002A448C File Offset: 0x002A268C
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A857 RID: 43095 RVA: 0x002A44C0 File Offset: 0x002A26C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293795, XrefRangeEnd = 293823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A858 RID: 43096 RVA: 0x002A44F4 File Offset: 0x002A26F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293831, RefRangeEnd = 293834, XrefRangeStart = 293823, XrefRangeEnd = 293831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashInstance GetCashInstance(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
		}

		// Token: 0x0600A859 RID: 43097 RVA: 0x002A4540 File Offset: 0x002A2740
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 293859, RefRangeEnd = 293871, XrefRangeStart = 293834, XrefRangeEnd = 293859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A85A RID: 43098 RVA: 0x002A45B4 File Offset: 0x002A27B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293884, RefRangeEnd = 293886, XrefRangeStart = 293871, XrefRangeEnd = 293884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A85B RID: 43099 RVA: 0x002A4628 File Offset: 0x002A2828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293886, XrefRangeEnd = 293891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A85C RID: 43100 RVA: 0x002A4678 File Offset: 0x002A2878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293901, RefRangeEnd = 293902, XrefRangeStart = 293891, XrefRangeEnd = 293901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLifetimeEarnings(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A85D RID: 43101 RVA: 0x002A46B8 File Offset: 0x002A28B8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 293952, RefRangeEnd = 293976, XrefRangeStart = 293902, XrefRangeEnd = 293952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref visualizeChange;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playCashSound;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A85E RID: 43102 RVA: 0x002A4714 File Offset: 0x002A2914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293976, XrefRangeEnd = 293981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeDisplay);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A85F RID: 43103 RVA: 0x002A4764 File Offset: 0x002A2964
		[CallerCount(116)]
		[CachedScanResults(RefRangeStart = 294021, RefRangeEnd = 294137, XrefRangeStart = 293981, XrefRangeEnd = 294021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref showDecimals;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref includeColor;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A860 RID: 43104 RVA: 0x002A47B8 File Offset: 0x002A29B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294137, XrefRangeEnd = 294150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A861 RID: 43105 RVA: 0x002A47FC File Offset: 0x002A29FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294175, RefRangeEnd = 294176, XrefRangeStart = 294150, XrefRangeEnd = 294175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(MoneyData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_Load_Public_Void_MoneyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A862 RID: 43106 RVA: 0x002A4840 File Offset: 0x002A2A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294176, XrefRangeEnd = 294190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNetworthAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A863 RID: 43107 RVA: 0x002A4874 File Offset: 0x002A2A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294194, RefRangeEnd = 294196, XrefRangeStart = 294190, XrefRangeEnd = 294194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNetWorth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_GetNetWorth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A864 RID: 43108 RVA: 0x002A48B0 File Offset: 0x002A2AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294196, XrefRangeEnd = 294223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A865 RID: 43109 RVA: 0x002A48EC File Offset: 0x002A2AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294223, XrefRangeEnd = 294269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A866 RID: 43110 RVA: 0x002A4928 File Offset: 0x002A2B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294269, XrefRangeEnd = 294272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A867 RID: 43111 RVA: 0x002A4964 File Offset: 0x002A2B64
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x002A49A0 File Offset: 0x002A2BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294272, XrefRangeEnd = 294285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A869 RID: 43113 RVA: 0x002A4A14 File Offset: 0x002A2C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293884, RefRangeEnd = 293886, XrefRangeStart = 293884, XrefRangeEnd = 293886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A86A RID: 43114 RVA: 0x002A4A88 File Offset: 0x002A2C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294285, XrefRangeEnd = 294292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x002A4AEC File Offset: 0x002A2CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293884, RefRangeEnd = 293886, XrefRangeStart = 293884, XrefRangeEnd = 293886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A86C RID: 43116 RVA: 0x002A4B60 File Offset: 0x002A2D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294363, RefRangeEnd = 294364, XrefRangeStart = 294292, XrefRangeEnd = 294363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _quantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A86D RID: 43117 RVA: 0x002A4BD4 File Offset: 0x002A2DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294364, XrefRangeEnd = 294370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A86E RID: 43118 RVA: 0x002A4C24 File Offset: 0x002A2E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293901, RefRangeEnd = 293902, XrefRangeStart = 293901, XrefRangeEnd = 293902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A86F RID: 43119 RVA: 0x002A4C64 File Offset: 0x002A2E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294370, XrefRangeEnd = 294386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A870 RID: 43120 RVA: 0x002A4CA4 File Offset: 0x002A2EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294386, XrefRangeEnd = 294404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600A871 RID: 43121 RVA: 0x002A4D08 File Offset: 0x002A2F08
		// (set) Token: 0x0600A872 RID: 43122 RVA: 0x002A4D44 File Offset: 0x002A2F44
		public unsafe float SyncAccessor_onlineBalance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 294412, RefRangeEnd = 294413, XrefRangeStart = 294404, XrefRangeEnd = 294412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A873 RID: 43123 RVA: 0x002A4D90 File Offset: 0x002A2F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294413, XrefRangeEnd = 294417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Money_MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600A874 RID: 43124 RVA: 0x002A4E04 File Offset: 0x002A3004
		// (set) Token: 0x0600A875 RID: 43125 RVA: 0x002A4E40 File Offset: 0x002A3040
		public unsafe float SyncAccessor_lifetimeEarnings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61709, RefRangeEnd = 61710, XrefRangeStart = 61709, XrefRangeEnd = 61710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294417, XrefRangeEnd = 294425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600A876 RID: 43126 RVA: 0x002A4E8C File Offset: 0x002A308C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294425, XrefRangeEnd = 294428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoneyManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A877 RID: 43127 RVA: 0x00052BB1 File Offset: 0x00050DB1
		public MoneyManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600A878 RID: 43128 RVA: 0x002A4EC8 File Offset: 0x002A30C8
		// (set) Token: 0x0600A879 RID: 43129 RVA: 0x00052BBA File Offset: 0x00050DBA
		public unsafe static string MONEY_TEXT_COLOR
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600A87A RID: 43130 RVA: 0x002A4EE8 File Offset: 0x002A30E8
		// (set) Token: 0x0600A87B RID: 43131 RVA: 0x00052BCC File Offset: 0x00050DCC
		public unsafe static string MONEY_TEXT_COLOR_DARKER
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600A87C RID: 43132 RVA: 0x002A4F08 File Offset: 0x002A3108
		// (set) Token: 0x0600A87D RID: 43133 RVA: 0x00052BDE File Offset: 0x00050DDE
		public unsafe static string ONLINE_BALANCE_COLOR
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MoneyManager.NativeFieldInfoPtr_ONLINE_BALANCE_COLOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600A87E RID: 43134 RVA: 0x002A4F28 File Offset: 0x002A3128
		// (set) Token: 0x0600A87F RID: 43135 RVA: 0x00052BF0 File Offset: 0x00050DF0
		public unsafe List<Transaction> ledger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transaction>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_ledger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600A880 RID: 43136 RVA: 0x002A4F58 File Offset: 0x002A3158
		// (set) Token: 0x0600A881 RID: 43137 RVA: 0x00052C0F File Offset: 0x00050E0F
		public unsafe float onlineBalance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onlineBalance)) = value;
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600A882 RID: 43138 RVA: 0x002A4F80 File Offset: 0x002A3180
		// (set) Token: 0x0600A883 RID: 43139 RVA: 0x00052C2A File Offset: 0x00050E2A
		public unsafe float lifetimeEarnings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_lifetimeEarnings)) = value;
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600A884 RID: 43140 RVA: 0x002A4FA8 File Offset: 0x002A31A8
		// (set) Token: 0x0600A885 RID: 43141 RVA: 0x00052C45 File Offset: 0x00050E45
		public unsafe float _LastCalculatedNetworth_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField)) = value;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600A886 RID: 43142 RVA: 0x002A4FD0 File Offset: 0x002A31D0
		// (set) Token: 0x0600A887 RID: 43143 RVA: 0x00052C60 File Offset: 0x00050E60
		public unsafe AudioSourceController CashSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_CashSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600A888 RID: 43144 RVA: 0x002A5000 File Offset: 0x002A3200
		// (set) Token: 0x0600A889 RID: 43145 RVA: 0x00052C7F File Offset: 0x00050E7F
		public unsafe GameObject moneyChangePrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_moneyChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600A88A RID: 43146 RVA: 0x002A5030 File Offset: 0x002A3230
		// (set) Token: 0x0600A88B RID: 43147 RVA: 0x00052C9E File Offset: 0x00050E9E
		public unsafe GameObject cashChangePrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_cashChangePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600A88C RID: 43148 RVA: 0x002A5060 File Offset: 0x002A3260
		// (set) Token: 0x0600A88D RID: 43149 RVA: 0x00052CBD File Offset: 0x00050EBD
		public unsafe Sprite LaunderingNotificationIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_LaunderingNotificationIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600A88E RID: 43150 RVA: 0x002A5090 File Offset: 0x002A3290
		// (set) Token: 0x0600A88F RID: 43151 RVA: 0x00052CDC File Offset: 0x00050EDC
		public unsafe Il2CppSystem.Action<MoneyManager.FloatContainer> onNetworthCalculation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<MoneyManager.FloatContainer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_onNetworthCalculation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600A890 RID: 43152 RVA: 0x002A50C0 File Offset: 0x002A32C0
		// (set) Token: 0x0600A891 RID: 43153 RVA: 0x00052CFB File Offset: 0x00050EFB
		public unsafe MoneyLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoneyLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x002A50F0 File Offset: 0x002A32F0
		// (set) Token: 0x0600A893 RID: 43155 RVA: 0x00052D1A File Offset: 0x00050F1A
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x0600A894 RID: 43156 RVA: 0x002A5120 File Offset: 0x002A3320
		// (set) Token: 0x0600A895 RID: 43157 RVA: 0x00052D39 File Offset: 0x00050F39
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600A896 RID: 43158 RVA: 0x002A5150 File Offset: 0x002A3350
		// (set) Token: 0x0600A897 RID: 43159 RVA: 0x00052D58 File Offset: 0x00050F58
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600A898 RID: 43160 RVA: 0x002A5178 File Offset: 0x002A3378
		// (set) Token: 0x0600A899 RID: 43161 RVA: 0x00052D73 File Offset: 0x00050F73
		public unsafe SyncVar<float> syncVar___onlineBalance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___onlineBalance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600A89A RID: 43162 RVA: 0x002A51A8 File Offset: 0x002A33A8
		// (set) Token: 0x0600A89B RID: 43163 RVA: 0x00052D92 File Offset: 0x00050F92
		public unsafe SyncVar<float> syncVar___lifetimeEarnings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_syncVar___lifetimeEarnings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600A89C RID: 43164 RVA: 0x002A51D8 File Offset: 0x002A33D8
		// (set) Token: 0x0600A89D RID: 43165 RVA: 0x00052DB1 File Offset: 0x00050FB1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600A89E RID: 43166 RVA: 0x002A5200 File Offset: 0x002A3400
		// (set) Token: 0x0600A89F RID: 43167 RVA: 0x00052DCC File Offset: 0x00050FCC
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040070CD RID: 28877
		private static readonly System.IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR;

		// Token: 0x040070CE RID: 28878
		private static readonly System.IntPtr NativeFieldInfoPtr_MONEY_TEXT_COLOR_DARKER;

		// Token: 0x040070CF RID: 28879
		private static readonly System.IntPtr NativeFieldInfoPtr_ONLINE_BALANCE_COLOR;

		// Token: 0x040070D0 RID: 28880
		private static readonly System.IntPtr NativeFieldInfoPtr_ledger;

		// Token: 0x040070D1 RID: 28881
		private static readonly System.IntPtr NativeFieldInfoPtr_onlineBalance;

		// Token: 0x040070D2 RID: 28882
		private static readonly System.IntPtr NativeFieldInfoPtr_lifetimeEarnings;

		// Token: 0x040070D3 RID: 28883
		private static readonly System.IntPtr NativeFieldInfoPtr__LastCalculatedNetworth_k__BackingField;

		// Token: 0x040070D4 RID: 28884
		private static readonly System.IntPtr NativeFieldInfoPtr_CashSound;

		// Token: 0x040070D5 RID: 28885
		private static readonly System.IntPtr NativeFieldInfoPtr_moneyChangePrefab;

		// Token: 0x040070D6 RID: 28886
		private static readonly System.IntPtr NativeFieldInfoPtr_cashChangePrefab;

		// Token: 0x040070D7 RID: 28887
		private static readonly System.IntPtr NativeFieldInfoPtr_LaunderingNotificationIcon;

		// Token: 0x040070D8 RID: 28888
		private static readonly System.IntPtr NativeFieldInfoPtr_onNetworthCalculation;

		// Token: 0x040070D9 RID: 28889
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040070DA RID: 28890
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040070DB RID: 28891
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040070DC RID: 28892
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040070DD RID: 28893
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___onlineBalance;

		// Token: 0x040070DE RID: 28894
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___lifetimeEarnings;

		// Token: 0x040070DF RID: 28895
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040070E0 RID: 28896
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040070E1 RID: 28897
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LifetimeEarnings_Public_get_Single_0;

		// Token: 0x040070E2 RID: 28898
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LastCalculatedNetworth_Public_get_Single_0;

		// Token: 0x040070E3 RID: 28899
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LastCalculatedNetworth_Protected_set_Void_Single_0;

		// Token: 0x040070E4 RID: 28900
		private static readonly System.IntPtr NativeMethodInfoPtr_get_cashBalance_Public_get_Single_0;

		// Token: 0x040070E5 RID: 28901
		private static readonly System.IntPtr NativeMethodInfoPtr_get_cashInstance_Protected_get_CashInstance_0;

		// Token: 0x040070E6 RID: 28902
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040070E7 RID: 28903
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040070E8 RID: 28904
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040070E9 RID: 28905
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070EA RID: 28906
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040070EB RID: 28907
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040070EC RID: 28908
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040070ED RID: 28909
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040070EE RID: 28910
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040070EF RID: 28911
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040070F0 RID: 28912
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040070F1 RID: 28913
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040070F2 RID: 28914
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040070F3 RID: 28915
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040070F4 RID: 28916
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040070F5 RID: 28917
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x040070F6 RID: 28918
		private static readonly System.IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040070F7 RID: 28919
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040070F8 RID: 28920
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040070F9 RID: 28921
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCashInstance_Public_CashInstance_Single_0;

		// Token: 0x040070FA RID: 28922
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateOnlineTransaction_Public_Void_String_Single_Single_String_0;

		// Token: 0x040070FB RID: 28923
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveOnlineTransaction_Private_Void_String_Single_Single_String_0;

		// Token: 0x040070FC RID: 28924
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOnlineBalanceChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x040070FD RID: 28925
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeLifetimeEarnings_Public_Void_Single_0;

		// Token: 0x040070FE RID: 28926
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeCashBalance_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x040070FF RID: 28927
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowCashChange_Protected_IEnumerator_RectTransform_0;

		// Token: 0x04007100 RID: 28928
		private static readonly System.IntPtr NativeMethodInfoPtr_FormatAmount_Public_Static_String_Single_Boolean_Boolean_0;

		// Token: 0x04007101 RID: 28929
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04007102 RID: 28930
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_MoneyData_0;

		// Token: 0x04007103 RID: 28931
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckNetworthAchievements_Public_Void_0;

		// Token: 0x04007104 RID: 28932
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetWorth_Public_Single_0;

		// Token: 0x04007105 RID: 28933
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007106 RID: 28934
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007107 RID: 28935
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007108 RID: 28936
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007109 RID: 28937
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x0400710A RID: 28938
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___CreateOnlineTransaction_1419830531_Public_Void_String_Single_Single_String_0;

		// Token: 0x0400710B RID: 28939
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400710C RID: 28940
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x0400710D RID: 28941
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOnlineTransaction_1419830531_Private_Void_String_Single_Single_String_0;

		// Token: 0x0400710E RID: 28942
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOnlineTransaction_1419830531_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400710F RID: 28943
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeLifetimeEarnings_431000436_Private_Void_Single_0;

		// Token: 0x04007110 RID: 28944
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ChangeLifetimeEarnings_431000436_Public_Void_Single_0;

		// Token: 0x04007111 RID: 28945
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeLifetimeEarnings_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007112 RID: 28946
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_onlineBalance_Public_get_Single_0;

		// Token: 0x04007113 RID: 28947
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_onlineBalance_Public_set_Void_Single_Boolean_0;

		// Token: 0x04007114 RID: 28948
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Money_MoneyManager_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04007115 RID: 28949
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_lifetimeEarnings_Public_get_Single_0;

		// Token: 0x04007116 RID: 28950
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_lifetimeEarnings_Public_set_Void_Single_Boolean_0;

		// Token: 0x04007117 RID: 28951
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C21 RID: 3105
		public class FloatContainer : Il2CppSystem.Object
		{
			// Token: 0x0600E36E RID: 58222 RVA: 0x0035CE78 File Offset: 0x0035B078
			// Note: this type is marked as 'beforefieldinit'.
			static FloatContainer()
			{
				Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "FloatContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr);
				MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, "<value>k__BackingField");
				MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100684010);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100684011);
				MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100684012);
				MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr, 100684013);
			}

			// Token: 0x17004625 RID: 17957
			// (get) Token: 0x0600E36F RID: 58223 RVA: 0x0035CF08 File Offset: 0x0035B108
			// (set) Token: 0x0600E370 RID: 58224 RVA: 0x0035CF44 File Offset: 0x0035B144
			public unsafe float value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 31384, RefRangeEnd = 31388, XrefRangeStart = 31384, XrefRangeEnd = 31388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref value;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_set_value_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}
			}

			// Token: 0x0600E371 RID: 58225 RVA: 0x0035CF84 File Offset: 0x0035B184
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 122443, RefRangeEnd = 122449, XrefRangeStart = 122443, XrefRangeEnd = 122449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ChangeValue(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E372 RID: 58226 RVA: 0x0035CFC4 File Offset: 0x0035B1C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager.FloatContainer>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager.FloatContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E373 RID: 58227 RVA: 0x0006E872 File Offset: 0x0006CA72
			public FloatContainer(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004624 RID: 17956
			// (get) Token: 0x0600E374 RID: 58228 RVA: 0x0035D000 File Offset: 0x0035B200
			// (set) Token: 0x0600E375 RID: 58229 RVA: 0x0006E87B File Offset: 0x0006CA7B
			public unsafe float _value_k__BackingField
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager.FloatContainer.NativeFieldInfoPtr__value_k__BackingField)) = value;
				}
			}

			// Token: 0x04009859 RID: 39001
			private static readonly System.IntPtr NativeFieldInfoPtr__value_k__BackingField;

			// Token: 0x0400985A RID: 39002
			private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

			// Token: 0x0400985B RID: 39003
			private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Private_set_Void_Single_0;

			// Token: 0x0400985C RID: 39004
			private static readonly System.IntPtr NativeMethodInfoPtr_ChangeValue_Public_Void_Single_0;

			// Token: 0x0400985D RID: 39005
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C22 RID: 3106
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowCashChange>d__58")]
		public sealed class _ShowCashChange_d__58 : Il2CppSystem.Object
		{
			// Token: 0x0600E376 RID: 58230 RVA: 0x0035D028 File Offset: 0x0035B228
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowCashChange_d__58()
			{
				Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowCashChange>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr);
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100684014);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100684015);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100684016);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100684017);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100684018);
				MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr, 100684019);
			}

			// Token: 0x0600E377 RID: 58231 RVA: 0x0035D16C File Offset: 0x0035B36C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowCashChange_d__58(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowCashChange_d__58>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E378 RID: 58232 RVA: 0x0035D1B4 File Offset: 0x0035B3B4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E379 RID: 58233 RVA: 0x0035D1E8 File Offset: 0x0035B3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293565, XrefRangeEnd = 293588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700462E RID: 17966
			// (get) Token: 0x0600E37A RID: 58234 RVA: 0x0035D224 File Offset: 0x0035B424
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E37B RID: 58235 RVA: 0x0035D264 File Offset: 0x0035B464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293588, XrefRangeEnd = 293593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700462F RID: 17967
			// (get) Token: 0x0600E37C RID: 58236 RVA: 0x0035D298 File Offset: 0x0035B498
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowCashChange_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E37D RID: 58237 RVA: 0x0006E896 File Offset: 0x0006CA96
			public _ShowCashChange_d__58(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004626 RID: 17958
			// (get) Token: 0x0600E37E RID: 58238 RVA: 0x0035D2D8 File Offset: 0x0035B4D8
			// (set) Token: 0x0600E37F RID: 58239 RVA: 0x0006E89F File Offset: 0x0006CA9F
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004627 RID: 17959
			// (get) Token: 0x0600E380 RID: 58240 RVA: 0x0035D300 File Offset: 0x0035B500
			// (set) Token: 0x0600E381 RID: 58241 RVA: 0x0006E8BA File Offset: 0x0006CABA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004628 RID: 17960
			// (get) Token: 0x0600E382 RID: 58242 RVA: 0x0035D330 File Offset: 0x0035B530
			// (set) Token: 0x0600E383 RID: 58243 RVA: 0x0006E8D9 File Offset: 0x0006CAD9
			public unsafe RectTransform changeDisplay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004629 RID: 17961
			// (get) Token: 0x0600E384 RID: 58244 RVA: 0x0035D360 File Offset: 0x0035B560
			// (set) Token: 0x0600E385 RID: 58245 RVA: 0x0006E8F8 File Offset: 0x0006CAF8
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700462A RID: 17962
			// (get) Token: 0x0600E386 RID: 58246 RVA: 0x0035D390 File Offset: 0x0035B590
			// (set) Token: 0x0600E387 RID: 58247 RVA: 0x0006E917 File Offset: 0x0006CB17
			public unsafe float _startVert_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x1700462B RID: 17963
			// (get) Token: 0x0600E388 RID: 58248 RVA: 0x0035D3B8 File Offset: 0x0035B5B8
			// (set) Token: 0x0600E389 RID: 58249 RVA: 0x0006E932 File Offset: 0x0006CB32
			public unsafe float _lerpTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x1700462C RID: 17964
			// (get) Token: 0x0600E38A RID: 58250 RVA: 0x0035D3E0 File Offset: 0x0035B5E0
			// (set) Token: 0x0600E38B RID: 58251 RVA: 0x0006E94D File Offset: 0x0006CB4D
			public unsafe float _vertOffset_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x1700462D RID: 17965
			// (get) Token: 0x0600E38C RID: 58252 RVA: 0x0035D408 File Offset: 0x0035B608
			// (set) Token: 0x0600E38D RID: 58253 RVA: 0x0006E968 File Offset: 0x0006CB68
			public unsafe float _i_5__6
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowCashChange_d__58.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x0400985E RID: 39006
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400985F RID: 39007
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009860 RID: 39008
			private static readonly System.IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x04009861 RID: 39009
			private static readonly System.IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x04009862 RID: 39010
			private static readonly System.IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x04009863 RID: 39011
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009864 RID: 39012
			private static readonly System.IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x04009865 RID: 39013
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x04009866 RID: 39014
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009867 RID: 39015
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009868 RID: 39016
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009869 RID: 39017
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400986A RID: 39018
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400986B RID: 39019
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C23 RID: 3107
		[ObfuscatedName("ScheduleOne.Money.MoneyManager+<ShowOnlineBalanceChange>d__55")]
		public sealed class _ShowOnlineBalanceChange_d__55 : Il2CppSystem.Object
		{
			// Token: 0x0600E38E RID: 58254 RVA: 0x0035D430 File Offset: 0x0035B630
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOnlineBalanceChange_d__55()
			{
				Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoneyManager>.NativeClassPtr, "<ShowOnlineBalanceChange>d__55");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<>1__state");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<>2__current");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "changeDisplay");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<text>5__2");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<startVert>5__3");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<lerpTime>5__4");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<vertOffset>5__5");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, "<i>5__6");
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100684020);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100684021);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100684022);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100684023);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100684024);
				MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr, 100684025);
			}

			// Token: 0x0600E38F RID: 58255 RVA: 0x0035D574 File Offset: 0x0035B774
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOnlineBalanceChange_d__55(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyManager._ShowOnlineBalanceChange_d__55>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E390 RID: 58256 RVA: 0x0035D5BC File Offset: 0x0035B7BC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E391 RID: 58257 RVA: 0x0035D5F0 File Offset: 0x0035B7F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293593, XrefRangeEnd = 293616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004638 RID: 17976
			// (get) Token: 0x0600E392 RID: 58258 RVA: 0x0035D62C File Offset: 0x0035B82C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E393 RID: 58259 RVA: 0x0035D66C File Offset: 0x0035B86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293616, XrefRangeEnd = 293621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004639 RID: 17977
			// (get) Token: 0x0600E394 RID: 58260 RVA: 0x0035D6A0 File Offset: 0x0035B8A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyManager._ShowOnlineBalanceChange_d__55.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E395 RID: 58261 RVA: 0x0006E983 File Offset: 0x0006CB83
			public _ShowOnlineBalanceChange_d__55(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004630 RID: 17968
			// (get) Token: 0x0600E396 RID: 58262 RVA: 0x0035D6E0 File Offset: 0x0035B8E0
			// (set) Token: 0x0600E397 RID: 58263 RVA: 0x0006E98C File Offset: 0x0006CB8C
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004631 RID: 17969
			// (get) Token: 0x0600E398 RID: 58264 RVA: 0x0035D708 File Offset: 0x0035B908
			// (set) Token: 0x0600E399 RID: 58265 RVA: 0x0006E9A7 File Offset: 0x0006CBA7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004632 RID: 17970
			// (get) Token: 0x0600E39A RID: 58266 RVA: 0x0035D738 File Offset: 0x0035B938
			// (set) Token: 0x0600E39B RID: 58267 RVA: 0x0006E9C6 File Offset: 0x0006CBC6
			public unsafe RectTransform changeDisplay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr_changeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004633 RID: 17971
			// (get) Token: 0x0600E39C RID: 58268 RVA: 0x0035D768 File Offset: 0x0035B968
			// (set) Token: 0x0600E39D RID: 58269 RVA: 0x0006E9E5 File Offset: 0x0006CBE5
			public unsafe TextMeshProUGUI _text_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__text_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004634 RID: 17972
			// (get) Token: 0x0600E39E RID: 58270 RVA: 0x0035D798 File Offset: 0x0035B998
			// (set) Token: 0x0600E39F RID: 58271 RVA: 0x0006EA04 File Offset: 0x0006CC04
			public unsafe float _startVert_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x17004635 RID: 17973
			// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x0035D7C0 File Offset: 0x0035B9C0
			// (set) Token: 0x0600E3A1 RID: 58273 RVA: 0x0006EA1F File Offset: 0x0006CC1F
			public unsafe float _lerpTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17004636 RID: 17974
			// (get) Token: 0x0600E3A2 RID: 58274 RVA: 0x0035D7E8 File Offset: 0x0035B9E8
			// (set) Token: 0x0600E3A3 RID: 58275 RVA: 0x0006EA3A File Offset: 0x0006CC3A
			public unsafe float _vertOffset_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__vertOffset_5__5)) = value;
				}
			}

			// Token: 0x17004637 RID: 17975
			// (get) Token: 0x0600E3A4 RID: 58276 RVA: 0x0035D810 File Offset: 0x0035BA10
			// (set) Token: 0x0600E3A5 RID: 58277 RVA: 0x0006EA55 File Offset: 0x0006CC55
			public unsafe float _i_5__6
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyManager._ShowOnlineBalanceChange_d__55.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x0400986C RID: 39020
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400986D RID: 39021
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400986E RID: 39022
			private static readonly System.IntPtr NativeFieldInfoPtr_changeDisplay;

			// Token: 0x0400986F RID: 39023
			private static readonly System.IntPtr NativeFieldInfoPtr__text_5__2;

			// Token: 0x04009870 RID: 39024
			private static readonly System.IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x04009871 RID: 39025
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04009872 RID: 39026
			private static readonly System.IntPtr NativeFieldInfoPtr__vertOffset_5__5;

			// Token: 0x04009873 RID: 39027
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x04009874 RID: 39028
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009875 RID: 39029
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009876 RID: 39030
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009877 RID: 39031
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009878 RID: 39032
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009879 RID: 39033
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
