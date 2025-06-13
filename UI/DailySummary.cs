using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000654 RID: 1620
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x06008DFB RID: 36347 RVA: 0x00254120 File Offset: 0x00252320
		// Note: this type is marked as 'beforefieldinit'.
		static DailySummary()
		{
			Il2CppClassPointerStore<DailySummary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DailySummary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary>.NativeClassPtr);
			DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<IsOpen>k__BackingField");
			DailySummary.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Canvas");
			DailySummary.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Container");
			DailySummary.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Anim");
			DailySummary.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "TitleLabel");
			DailySummary.NativeFieldInfoPtr_ProductEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "ProductEntries");
			DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "PlayerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_DealerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "DealerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_XPGainedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "XPGainedLabel");
			DailySummary.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "onClosed");
			DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "itemsSoldByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByDealers");
			DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<xpGained>k__BackingField");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681027);
			DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681028);
			DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681029);
			DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681030);
			DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681031);
			DailySummary.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681032);
			DailySummary.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681033);
			DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681034);
			DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681035);
			DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681036);
			DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681037);
			DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681038);
			DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681039);
			DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681040);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681041);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681042);
			DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681043);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681044);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681045);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681046);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681047);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681048);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681049);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681050);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681051);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681052);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681053);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681054);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681055);
			DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100681056);
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x06008DFC RID: 36348 RVA: 0x002544E8 File Offset: 0x002526E8
		// (set) Token: 0x06008DFD RID: 36349 RVA: 0x00254524 File Offset: 0x00252724
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x06008DFE RID: 36350 RVA: 0x00254564 File Offset: 0x00252764
		// (set) Token: 0x06008DFF RID: 36351 RVA: 0x002545A0 File Offset: 0x002527A0
		public unsafe int xpGained
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x002545E0 File Offset: 0x002527E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259811, XrefRangeEnd = 259829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x0025461C File Offset: 0x0025281C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259911, RefRangeEnd = 259912, XrefRangeStart = 259829, XrefRangeEnd = 259911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x00254650 File Offset: 0x00252850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259912, XrefRangeEnd = 259922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x00254684 File Offset: 0x00252884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259922, XrefRangeEnd = 259925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x002546B8 File Offset: 0x002528B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259926, RefRangeEnd = 259927, XrefRangeStart = 259925, XrefRangeEnd = 259926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSoldItem(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x00254708 File Offset: 0x00252908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259937, RefRangeEnd = 259938, XrefRangeStart = 259927, XrefRangeEnd = 259937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x00254748 File Offset: 0x00252948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259948, RefRangeEnd = 259949, XrefRangeStart = 259938, XrefRangeEnd = 259948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x00254788 File Offset: 0x00252988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259960, RefRangeEnd = 259961, XrefRangeStart = 259949, XrefRangeEnd = 259960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x002547C8 File Offset: 0x002529C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x002547FC File Offset: 0x002529FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259961, XrefRangeEnd = 259971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailySummary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x00254838 File Offset: 0x00252A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259971, XrefRangeEnd = 259999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00254874 File Offset: 0x00252A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259999, XrefRangeEnd = 260002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x002548B0 File Offset: 0x00252AB0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x002548EC File Offset: 0x00252AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260024, RefRangeEnd = 260025, XrefRangeStart = 260002, XrefRangeEnd = 260024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x0025493C File Offset: 0x00252B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260025, XrefRangeEnd = 260038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x0025498C File Offset: 0x00252B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260038, XrefRangeEnd = 260050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x002549DC File Offset: 0x00252BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259937, RefRangeEnd = 259938, XrefRangeStart = 259937, XrefRangeEnd = 259938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x00254A1C File Offset: 0x00252C1C
		[CallerCount(0)]
		public unsafe void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x00254A5C File Offset: 0x00252C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260050, XrefRangeEnd = 260052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x00254AAC File Offset: 0x00252CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259948, RefRangeEnd = 259949, XrefRangeStart = 259948, XrefRangeEnd = 259949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E14 RID: 36372 RVA: 0x00254AEC File Offset: 0x00252CEC
		[CallerCount(0)]
		public unsafe void RpcLogic___AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E15 RID: 36373 RVA: 0x00254B2C File Offset: 0x00252D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260052, XrefRangeEnd = 260054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E16 RID: 36374 RVA: 0x00254B7C File Offset: 0x00252D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259960, RefRangeEnd = 259961, XrefRangeStart = 259960, XrefRangeEnd = 259961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x00254BBC File Offset: 0x00252DBC
		[CallerCount(0)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref xp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x00254BFC File Offset: 0x00252DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260054, XrefRangeEnd = 260057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x00254C4C File Offset: 0x00252E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260057, XrefRangeEnd = 260060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x00043BA3 File Offset: 0x00041DA3
		public DailySummary(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x06008E1B RID: 36379 RVA: 0x00254C88 File Offset: 0x00252E88
		// (set) Token: 0x06008E1C RID: 36380 RVA: 0x00043BAC File Offset: 0x00041DAC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x06008E1D RID: 36381 RVA: 0x00254CB0 File Offset: 0x00252EB0
		// (set) Token: 0x06008E1E RID: 36382 RVA: 0x00043BC7 File Offset: 0x00041DC7
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x06008E1F RID: 36383 RVA: 0x00254CE0 File Offset: 0x00252EE0
		// (set) Token: 0x06008E20 RID: 36384 RVA: 0x00043BE6 File Offset: 0x00041DE6
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x06008E21 RID: 36385 RVA: 0x00254D10 File Offset: 0x00252F10
		// (set) Token: 0x06008E22 RID: 36386 RVA: 0x00043C05 File Offset: 0x00041E05
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06008E23 RID: 36387 RVA: 0x00254D40 File Offset: 0x00252F40
		// (set) Token: 0x06008E24 RID: 36388 RVA: 0x00043C24 File Offset: 0x00041E24
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x06008E25 RID: 36389 RVA: 0x00254D70 File Offset: 0x00252F70
		// (set) Token: 0x06008E26 RID: 36390 RVA: 0x00043C43 File Offset: 0x00041E43
		public unsafe Il2CppReferenceArray<RectTransform> ProductEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x06008E27 RID: 36391 RVA: 0x00254DA0 File Offset: 0x00252FA0
		// (set) Token: 0x06008E28 RID: 36392 RVA: 0x00043C62 File Offset: 0x00041E62
		public unsafe TextMeshProUGUI PlayerEarningsLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x06008E29 RID: 36393 RVA: 0x00254DD0 File Offset: 0x00252FD0
		// (set) Token: 0x06008E2A RID: 36394 RVA: 0x00043C81 File Offset: 0x00041E81
		public unsafe TextMeshProUGUI DealerEarningsLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x06008E2B RID: 36395 RVA: 0x00254E00 File Offset: 0x00253000
		// (set) Token: 0x06008E2C RID: 36396 RVA: 0x00043CA0 File Offset: 0x00041EA0
		public unsafe TextMeshProUGUI XPGainedLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x06008E2D RID: 36397 RVA: 0x00254E30 File Offset: 0x00253030
		// (set) Token: 0x06008E2E RID: 36398 RVA: 0x00043CBF File Offset: 0x00041EBF
		public unsafe UnityEvent onClosed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x06008E2F RID: 36399 RVA: 0x00254E60 File Offset: 0x00253060
		// (set) Token: 0x06008E30 RID: 36400 RVA: 0x00043CDE File Offset: 0x00041EDE
		public unsafe Dictionary<string, int> itemsSoldByPlayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x06008E31 RID: 36401 RVA: 0x00254E90 File Offset: 0x00253090
		// (set) Token: 0x06008E32 RID: 36402 RVA: 0x00043CFD File Offset: 0x00041EFD
		public unsafe float moneyEarnedByPlayer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer)) = value;
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x06008E33 RID: 36403 RVA: 0x00254EB8 File Offset: 0x002530B8
		// (set) Token: 0x06008E34 RID: 36404 RVA: 0x00043D18 File Offset: 0x00041F18
		public unsafe float moneyEarnedByDealers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers)) = value;
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x06008E35 RID: 36405 RVA: 0x00254EE0 File Offset: 0x002530E0
		// (set) Token: 0x06008E36 RID: 36406 RVA: 0x00043D33 File Offset: 0x00041F33
		public unsafe int _xpGained_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x06008E37 RID: 36407 RVA: 0x00254F08 File Offset: 0x00253108
		// (set) Token: 0x06008E38 RID: 36408 RVA: 0x00043D4E File Offset: 0x00041F4E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x00254F30 File Offset: 0x00253130
		// (set) Token: 0x06008E3A RID: 36410 RVA: 0x00043D69 File Offset: 0x00041F69
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400604B RID: 24651
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400604C RID: 24652
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400604D RID: 24653
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400604E RID: 24654
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400604F RID: 24655
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006050 RID: 24656
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductEntries;

		// Token: 0x04006051 RID: 24657
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerEarningsLabel;

		// Token: 0x04006052 RID: 24658
		private static readonly System.IntPtr NativeFieldInfoPtr_DealerEarningsLabel;

		// Token: 0x04006053 RID: 24659
		private static readonly System.IntPtr NativeFieldInfoPtr_XPGainedLabel;

		// Token: 0x04006054 RID: 24660
		private static readonly System.IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x04006055 RID: 24661
		private static readonly System.IntPtr NativeFieldInfoPtr_itemsSoldByPlayer;

		// Token: 0x04006056 RID: 24662
		private static readonly System.IntPtr NativeFieldInfoPtr_moneyEarnedByPlayer;

		// Token: 0x04006057 RID: 24663
		private static readonly System.IntPtr NativeFieldInfoPtr_moneyEarnedByDealers;

		// Token: 0x04006058 RID: 24664
		private static readonly System.IntPtr NativeFieldInfoPtr__xpGained_k__BackingField;

		// Token: 0x04006059 RID: 24665
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400605A RID: 24666
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400605B RID: 24667
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400605C RID: 24668
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400605D RID: 24669
		private static readonly System.IntPtr NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0;

		// Token: 0x0400605E RID: 24670
		private static readonly System.IntPtr NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0;

		// Token: 0x0400605F RID: 24671
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006060 RID: 24672
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006061 RID: 24673
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006062 RID: 24674
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x04006063 RID: 24675
		private static readonly System.IntPtr NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0;

		// Token: 0x04006064 RID: 24676
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0;

		// Token: 0x04006065 RID: 24677
		private static readonly System.IntPtr NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0;

		// Token: 0x04006066 RID: 24678
		private static readonly System.IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04006067 RID: 24679
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearStats_Private_Void_0;

		// Token: 0x04006068 RID: 24680
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006069 RID: 24681
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400606A RID: 24682
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400606B RID: 24683
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400606C RID: 24684
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0;

		// Token: 0x0400606D RID: 24685
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0;

		// Token: 0x0400606E RID: 24686
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400606F RID: 24687
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0;

		// Token: 0x04006070 RID: 24688
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0;

		// Token: 0x04006071 RID: 24689
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006072 RID: 24690
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0;

		// Token: 0x04006073 RID: 24691
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0;

		// Token: 0x04006074 RID: 24692
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006075 RID: 24693
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04006076 RID: 24694
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x04006077 RID: 24695
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006078 RID: 24696
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000B67 RID: 2919
		[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC10 RID: 56336 RVA: 0x00347F30 File Offset: 0x00346130
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr);
				DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "items");
				DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, 100681057);
				DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, 100681058);
			}

			// Token: 0x0600DC11 RID: 56337 RVA: 0x00347FAC File Offset: 0x003461AC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC12 RID: 56338 RVA: 0x00347FE8 File Offset: 0x003461E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259806, XrefRangeEnd = 259811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DC13 RID: 56339 RVA: 0x0006AC5F File Offset: 0x00068E5F
			public __c__DisplayClass21_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DD RID: 17373
			// (get) Token: 0x0600DC14 RID: 56340 RVA: 0x00348028 File Offset: 0x00346228
			// (set) Token: 0x0600DC15 RID: 56341 RVA: 0x0006AC68 File Offset: 0x00068E68
			public unsafe Il2CppStringArray items
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DE RID: 17374
			// (get) Token: 0x0600DC16 RID: 56342 RVA: 0x00348058 File Offset: 0x00346258
			// (set) Token: 0x0600DC17 RID: 56343 RVA: 0x0006AC87 File Offset: 0x00068E87
			public unsafe DailySummary __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400940E RID: 37902
			private static readonly System.IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400940F RID: 37903
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009410 RID: 37904
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009411 RID: 37905
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CCB RID: 3275
			[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass21_0+<<Open>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EAB9 RID: 60089 RVA: 0x0037218C File Offset: 0x0037038C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "<<Open>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681059);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681060);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681061);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681062);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681063);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681064);
				}

				// Token: 0x0600EABA RID: 60090 RVA: 0x0037226C File Offset: 0x0037046C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EABB RID: 60091 RVA: 0x003722B4 File Offset: 0x003704B4
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EABC RID: 60092 RVA: 0x003722E8 File Offset: 0x003704E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259795, XrefRangeEnd = 259801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048A4 RID: 18596
				// (get) Token: 0x0600EABD RID: 60093 RVA: 0x00372324 File Offset: 0x00370524
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EABE RID: 60094 RVA: 0x00372364 File Offset: 0x00370564
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259801, XrefRangeEnd = 259806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048A5 RID: 18597
				// (get) Token: 0x0600EABF RID: 60095 RVA: 0x00372398 File Offset: 0x00370598
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAC0 RID: 60096 RVA: 0x0007227B File Offset: 0x0007047B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048A1 RID: 18593
				// (get) Token: 0x0600EAC1 RID: 60097 RVA: 0x003723D8 File Offset: 0x003705D8
				// (set) Token: 0x0600EAC2 RID: 60098 RVA: 0x00072284 File Offset: 0x00070484
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048A2 RID: 18594
				// (get) Token: 0x0600EAC3 RID: 60099 RVA: 0x00372400 File Offset: 0x00370600
				// (set) Token: 0x0600EAC4 RID: 60100 RVA: 0x0007229F File Offset: 0x0007049F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048A3 RID: 18595
				// (get) Token: 0x0600EAC5 RID: 60101 RVA: 0x00372430 File Offset: 0x00370630
				// (set) Token: 0x0600EAC6 RID: 60102 RVA: 0x000722BE File Offset: 0x000704BE
				public unsafe DailySummary.__c__DisplayClass21_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary.__c__DisplayClass21_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009D04 RID: 40196
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D05 RID: 40197
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D06 RID: 40198
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D07 RID: 40199
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D08 RID: 40200
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D09 RID: 40201
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D0A RID: 40202
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D0B RID: 40203
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D0C RID: 40204
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
