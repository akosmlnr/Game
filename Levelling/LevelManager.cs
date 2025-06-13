using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020003DE RID: 990
	public class LevelManager : NetworkSingleton<LevelManager>
	{
		// Token: 0x06004BEA RID: 19434 RVA: 0x001716A8 File Offset: 0x0016F8A8
		// Note: this type is marked as 'beforefieldinit'.
		static LevelManager()
		{
			Il2CppClassPointerStore<LevelManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "LevelManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager>.NativeClassPtr);
			LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "TIERS_PER_RANK");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MIN");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MAX");
			LevelManager.NativeFieldInfoPtr__Rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Rank>k__BackingField");
			LevelManager.NativeFieldInfoPtr_rankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "rankCount");
			LevelManager.NativeFieldInfoPtr__Tier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Tier>k__BackingField");
			LevelManager.NativeFieldInfoPtr__XP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<XP>k__BackingField");
			LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<TotalXP>k__BackingField");
			LevelManager.NativeFieldInfoPtr_onRankUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "onRankUp");
			LevelManager.NativeFieldInfoPtr_Unlockables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "Unlockables");
			LevelManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "loader");
			LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672785);
			LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672786);
			LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672787);
			LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672788);
			LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672789);
			LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672790);
			LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672791);
			LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672792);
			LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672793);
			LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672794);
			LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672795);
			LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672796);
			LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672797);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672798);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672799);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672800);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672801);
			LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672802);
			LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672803);
			LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672804);
			LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672805);
			LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672806);
			LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672807);
			LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672808);
			LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672809);
			LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672810);
			LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672811);
			LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672812);
			LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672813);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672814);
			LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672815);
			LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672816);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672817);
			LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672818);
			LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672819);
			LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672820);
			LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672821);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672822);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672823);
			LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672824);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672825);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672826);
			LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672827);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672828);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672829);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672830);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672831);
			LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672832);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672833);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672834);
			LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672835);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672836);
			LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672837);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672838);
			LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100672839);
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004BEB RID: 19435 RVA: 0x00171C64 File Offset: 0x0016FE64
		// (set) Token: 0x06004BEC RID: 19436 RVA: 0x00171CA0 File Offset: 0x0016FEA0
		public unsafe ERank Rank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004BED RID: 19437 RVA: 0x00171CE0 File Offset: 0x0016FEE0
		// (set) Token: 0x06004BEE RID: 19438 RVA: 0x00171D1C File Offset: 0x0016FF1C
		public unsafe int Tier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004BEF RID: 19439 RVA: 0x00171D5C File Offset: 0x0016FF5C
		// (set) Token: 0x06004BF0 RID: 19440 RVA: 0x00171D98 File Offset: 0x0016FF98
		public unsafe int XP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06004BF1 RID: 19441 RVA: 0x00171DD8 File Offset: 0x0016FFD8
		// (set) Token: 0x06004BF2 RID: 19442 RVA: 0x00171E14 File Offset: 0x00170014
		public unsafe int TotalXP
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 63475, RefRangeEnd = 63515, XrefRangeStart = 63475, XrefRangeEnd = 63515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06004BF3 RID: 19443 RVA: 0x00171E54 File Offset: 0x00170054
		public unsafe float XPToNextTier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168580, XrefRangeEnd = 168582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x00171E90 File Offset: 0x00170090
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168582, XrefRangeEnd = 168584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06004BF5 RID: 19445 RVA: 0x00171EC8 File Offset: 0x001700C8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168584, XrefRangeEnd = 168586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x00171F00 File Offset: 0x00170100
		public unsafe virtual Loader Loader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 97050, RefRangeEnd = 97051, XrefRangeStart = 97050, XrefRangeEnd = 97051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06004BF7 RID: 19447 RVA: 0x00171F40 File Offset: 0x00170140
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x00171F7C File Offset: 0x0017017C
		// (set) Token: 0x06004BF9 RID: 19449 RVA: 0x00171FBC File Offset: 0x001701BC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x00172000 File Offset: 0x00170200
		// (set) Token: 0x06004BFB RID: 19451 RVA: 0x00172040 File Offset: 0x00170240
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x00172084 File Offset: 0x00170284
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x001720C0 File Offset: 0x001702C0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00172100 File Offset: 0x00170300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168586, XrefRangeEnd = 168601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x0017213C File Offset: 0x0017033C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168601, XrefRangeEnd = 168604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00172178 File Offset: 0x00170378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168604, XrefRangeEnd = 168606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x001721C8 File Offset: 0x001703C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168606, XrefRangeEnd = 168612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x00172204 File Offset: 0x00170404
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 168623, RefRangeEnd = 168633, XrefRangeStart = 168612, XrefRangeEnd = 168623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00172244 File Offset: 0x00170444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168633, XrefRangeEnd = 168644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXPLocal(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00172284 File Offset: 0x00170484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168697, RefRangeEnd = 168700, XrefRangeStart = 168644, XrefRangeEnd = 168697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rank;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tier;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref xp;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalXp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00172300 File Offset: 0x00170500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168700, XrefRangeEnd = 168711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTierNetworked(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref after;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x0017234C File Offset: 0x0017054C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168711, XrefRangeEnd = 168713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00172380 File Offset: 0x00170580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168713, XrefRangeEnd = 168718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x001723C4 File Offset: 0x001705C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 168718, RefRangeEnd = 168723, XrefRangeStart = 168718, XrefRangeEnd = 168718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00172400 File Offset: 0x00170600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168757, RefRangeEnd = 168759, XrefRangeStart = 168723, XrefRangeEnd = 168757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnlockable(Unlockable unlockable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(unlockable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00172444 File Offset: 0x00170644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168778, RefRangeEnd = 168779, XrefRangeStart = 168759, XrefRangeEnd = 168778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalXPForRank(FullRank fullrank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref fullrank;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00172490 File Offset: 0x00170690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168799, RefRangeEnd = 168800, XrefRangeStart = 168779, XrefRangeEnd = 168799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank(int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref totalXp;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x001724DC File Offset: 0x001706DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 168803, RefRangeEnd = 168809, XrefRangeStart = 168800, XrefRangeEnd = 168803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXPForTier(ERank rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rank;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00172528 File Offset: 0x00170728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168810, RefRangeEnd = 168811, XrefRangeStart = 168809, XrefRangeEnd = 168810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetOrderLimitMultiplier(FullRank rank)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rank;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00172568 File Offset: 0x00170768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168811, RefRangeEnd = 168812, XrefRangeStart = 168811, XrefRangeEnd = 168811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRankOrderLimitMultiplier(ERank rank)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rank;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x001725A8 File Offset: 0x001707A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168812, XrefRangeEnd = 168839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x001725E4 File Offset: 0x001707E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168839, XrefRangeEnd = 168874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x00172620 File Offset: 0x00170820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168874, XrefRangeEnd = 168877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x0017265C File Offset: 0x0017085C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x00172698 File Offset: 0x00170898
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 168623, RefRangeEnd = 168633, XrefRangeStart = 168623, XrefRangeEnd = 168633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x001726D8 File Offset: 0x001708D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00172718 File Offset: 0x00170918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168877, XrefRangeEnd = 168891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x0017277C File Offset: 0x0017097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x001727BC File Offset: 0x001709BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168942, RefRangeEnd = 168943, XrefRangeStart = 168891, XrefRangeEnd = 168942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x001727FC File Offset: 0x001709FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168943, XrefRangeEnd = 168947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x0017284C File Offset: 0x00170A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168947, XrefRangeEnd = 168963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rank;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tier;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref xp;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalXp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x001728C8 File Offset: 0x00170AC8
		[CallerCount(0)]
		public unsafe void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rank;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tier;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref xp;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalXp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00172944 File Offset: 0x00170B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168963, XrefRangeEnd = 168972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00172994 File Offset: 0x00170B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168972, XrefRangeEnd = 168988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rank;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref tier;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref xp;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref totalXp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00172A10 File Offset: 0x00170C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168988, XrefRangeEnd = 168997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00172A60 File Offset: 0x00170C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref after;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00172AAC File Offset: 0x00170CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168997, XrefRangeEnd = 169010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref after;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00172AF8 File Offset: 0x00170CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169010, XrefRangeEnd = 169026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00172B48 File Offset: 0x00170D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169026, XrefRangeEnd = 169040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x000246CF File Offset: 0x000228CF
		public LevelManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x00172B84 File Offset: 0x00170D84
		// (set) Token: 0x06004C24 RID: 19492 RVA: 0x000246D8 File Offset: 0x000228D8
		public unsafe static int TIERS_PER_RANK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&value));
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x00172BA0 File Offset: 0x00170DA0
		// (set) Token: 0x06004C26 RID: 19494 RVA: 0x000246E6 File Offset: 0x000228E6
		public unsafe static int XP_PER_TIER_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06004C27 RID: 19495 RVA: 0x00172BBC File Offset: 0x00170DBC
		// (set) Token: 0x06004C28 RID: 19496 RVA: 0x000246F4 File Offset: 0x000228F4
		public unsafe static int XP_PER_TIER_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06004C29 RID: 19497 RVA: 0x00172BD8 File Offset: 0x00170DD8
		// (set) Token: 0x06004C2A RID: 19498 RVA: 0x00024702 File Offset: 0x00022902
		public unsafe ERank _Rank_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField)) = value;
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x00172C00 File Offset: 0x00170E00
		// (set) Token: 0x06004C2C RID: 19500 RVA: 0x0002471D File Offset: 0x0002291D
		public unsafe int rankCount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount)) = value;
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x00172C28 File Offset: 0x00170E28
		// (set) Token: 0x06004C2E RID: 19502 RVA: 0x00024738 File Offset: 0x00022938
		public unsafe int _Tier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x00172C50 File Offset: 0x00170E50
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x00024753 File Offset: 0x00022953
		public unsafe int _XP_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField)) = value;
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x00172C78 File Offset: 0x00170E78
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x0002476E File Offset: 0x0002296E
		public unsafe int _TotalXP_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField)) = value;
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06004C33 RID: 19507 RVA: 0x00172CA0 File Offset: 0x00170EA0
		// (set) Token: 0x06004C34 RID: 19508 RVA: 0x00024789 File Offset: 0x00022989
		public unsafe Il2CppSystem.Action<FullRank, FullRank> onRankUp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<FullRank, FullRank>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06004C35 RID: 19509 RVA: 0x00172CD0 File Offset: 0x00170ED0
		// (set) Token: 0x06004C36 RID: 19510 RVA: 0x000247A8 File Offset: 0x000229A8
		public unsafe Dictionary<FullRank, List<Unlockable>> Unlockables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FullRank, List<Unlockable>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06004C37 RID: 19511 RVA: 0x00172D00 File Offset: 0x00170F00
		// (set) Token: 0x06004C38 RID: 19512 RVA: 0x000247C7 File Offset: 0x000229C7
		public unsafe RankLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06004C39 RID: 19513 RVA: 0x00172D30 File Offset: 0x00170F30
		// (set) Token: 0x06004C3A RID: 19514 RVA: 0x000247E6 File Offset: 0x000229E6
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x00172D60 File Offset: 0x00170F60
		// (set) Token: 0x06004C3C RID: 19516 RVA: 0x00024805 File Offset: 0x00022A05
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004C3D RID: 19517 RVA: 0x00172D90 File Offset: 0x00170F90
		// (set) Token: 0x06004C3E RID: 19518 RVA: 0x00024824 File Offset: 0x00022A24
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004C3F RID: 19519 RVA: 0x00172DB8 File Offset: 0x00170FB8
		// (set) Token: 0x06004C40 RID: 19520 RVA: 0x0002483F File Offset: 0x00022A3F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004C41 RID: 19521 RVA: 0x00172DE0 File Offset: 0x00170FE0
		// (set) Token: 0x06004C42 RID: 19522 RVA: 0x0002485A File Offset: 0x00022A5A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400332D RID: 13101
		private static readonly System.IntPtr NativeFieldInfoPtr_TIERS_PER_RANK;

		// Token: 0x0400332E RID: 13102
		private static readonly System.IntPtr NativeFieldInfoPtr_XP_PER_TIER_MIN;

		// Token: 0x0400332F RID: 13103
		private static readonly System.IntPtr NativeFieldInfoPtr_XP_PER_TIER_MAX;

		// Token: 0x04003330 RID: 13104
		private static readonly System.IntPtr NativeFieldInfoPtr__Rank_k__BackingField;

		// Token: 0x04003331 RID: 13105
		private static readonly System.IntPtr NativeFieldInfoPtr_rankCount;

		// Token: 0x04003332 RID: 13106
		private static readonly System.IntPtr NativeFieldInfoPtr__Tier_k__BackingField;

		// Token: 0x04003333 RID: 13107
		private static readonly System.IntPtr NativeFieldInfoPtr__XP_k__BackingField;

		// Token: 0x04003334 RID: 13108
		private static readonly System.IntPtr NativeFieldInfoPtr__TotalXP_k__BackingField;

		// Token: 0x04003335 RID: 13109
		private static readonly System.IntPtr NativeFieldInfoPtr_onRankUp;

		// Token: 0x04003336 RID: 13110
		private static readonly System.IntPtr NativeFieldInfoPtr_Unlockables;

		// Token: 0x04003337 RID: 13111
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04003338 RID: 13112
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003339 RID: 13113
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400333A RID: 13114
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400333B RID: 13115
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400333C RID: 13116
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400333D RID: 13117
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Rank_Public_get_ERank_0;

		// Token: 0x0400333E RID: 13118
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0;

		// Token: 0x0400333F RID: 13119
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Tier_Public_get_Int32_0;

		// Token: 0x04003340 RID: 13120
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0;

		// Token: 0x04003341 RID: 13121
		private static readonly System.IntPtr NativeMethodInfoPtr_get_XP_Public_get_Int32_0;

		// Token: 0x04003342 RID: 13122
		private static readonly System.IntPtr NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0;

		// Token: 0x04003343 RID: 13123
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0;

		// Token: 0x04003344 RID: 13124
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0;

		// Token: 0x04003345 RID: 13125
		private static readonly System.IntPtr NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0;

		// Token: 0x04003346 RID: 13126
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003347 RID: 13127
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003348 RID: 13128
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003349 RID: 13129
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400334A RID: 13130
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400334B RID: 13131
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400334C RID: 13132
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400334D RID: 13133
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400334E RID: 13134
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400334F RID: 13135
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003350 RID: 13136
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003351 RID: 13137
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003352 RID: 13138
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003353 RID: 13139
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003354 RID: 13140
		private static readonly System.IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04003355 RID: 13141
		private static readonly System.IntPtr NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0;

		// Token: 0x04003356 RID: 13142
		private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x04003357 RID: 13143
		private static readonly System.IntPtr NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003358 RID: 13144
		private static readonly System.IntPtr NativeMethodInfoPtr_IncreaseTier_Private_Void_0;

		// Token: 0x04003359 RID: 13145
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400335A RID: 13146
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_0;

		// Token: 0x0400335B RID: 13147
		private static readonly System.IntPtr NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0;

		// Token: 0x0400335C RID: 13148
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0;

		// Token: 0x0400335D RID: 13149
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0;

		// Token: 0x0400335E RID: 13150
		private static readonly System.IntPtr NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0;

		// Token: 0x0400335F RID: 13151
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0;

		// Token: 0x04003360 RID: 13152
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0;

		// Token: 0x04003361 RID: 13153
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003362 RID: 13154
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003363 RID: 13155
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003364 RID: 13156
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003365 RID: 13157
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04003366 RID: 13158
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x04003367 RID: 13159
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003368 RID: 13160
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x04003369 RID: 13161
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x0400336A RID: 13162
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400336B RID: 13163
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400336C RID: 13164
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400336D RID: 13165
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400336E RID: 13166
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400336F RID: 13167
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003370 RID: 13168
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003371 RID: 13169
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x04003372 RID: 13170
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003373 RID: 13171
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009D3 RID: 2515
		[ObfuscatedName("ScheduleOne.Levelling.LevelManager+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF61 RID: 53089 RVA: 0x00324618 File Offset: 0x00322818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr);
				LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, "unlockable");
				LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, 100672840);
				LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr, 100672841);
			}

			// Token: 0x0600CF62 RID: 53090 RVA: 0x00324680 File Offset: 0x00322880
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager.__c__DisplayClass56_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF63 RID: 53091 RVA: 0x003246BC File Offset: 0x003228BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168576, XrefRangeEnd = 168580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddUnlockable_b__0(Unlockable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass56_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CF64 RID: 53092 RVA: 0x0006483B File Offset: 0x00062A3B
			public __c__DisplayClass56_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700404F RID: 16463
			// (get) Token: 0x0600CF65 RID: 53093 RVA: 0x0032470C File Offset: 0x0032290C
			// (set) Token: 0x0600CF66 RID: 53094 RVA: 0x00064844 File Offset: 0x00062A44
			public unsafe Unlockable unlockable
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Unlockable>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass56_0.NativeFieldInfoPtr_unlockable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C51 RID: 35921
			private static readonly System.IntPtr NativeFieldInfoPtr_unlockable;

			// Token: 0x04008C52 RID: 35922
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C53 RID: 35923
			private static readonly System.IntPtr NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0;
		}
	}
}
