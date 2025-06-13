using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x020004A9 RID: 1193
	public class OptionListFeature : Feature
	{
		// Token: 0x06006679 RID: 26233 RVA: 0x001D1240 File Offset: 0x001CF440
		// Note: this type is marked as 'beforefieldinit'.
		static OptionListFeature()
		{
			Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "OptionListFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr);
			OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "defaultOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "ownedOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "syncVar___ownedOptionIndex");
			OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted");
			OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.OptionListFeatureAssembly-CSharp.dll_Excuted");
			OptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676370);
			OptionListFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676371);
			OptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676372);
			OptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676373);
			OptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676374);
			OptionListFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676375);
			OptionListFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676376);
			OptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676377);
			OptionListFeature.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676378);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676379);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676380);
			OptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676381);
			OptionListFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676382);
			OptionListFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676383);
			OptionListFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676384);
			OptionListFeature.NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676385);
			OptionListFeature.NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676386);
			OptionListFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676387);
			OptionListFeature.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr, 100676388);
		}

		// Token: 0x0600667A RID: 26234 RVA: 0x001D1450 File Offset: 0x001CF650
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x001D148C File Offset: 0x001CF68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208879, XrefRangeEnd = 208900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr2) : null;
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x001D14E8 File Offset: 0x001CF6E8
		[CallerCount(0)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x001D1524 File Offset: 0x001CF724
		[CallerCount(0)]
		public unsafe virtual List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr2) : null;
		}

		// Token: 0x0600667E RID: 26238 RVA: 0x001D1570 File Offset: 0x001CF770
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x001D15BC File Offset: 0x001CF7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208900, XrefRangeEnd = 208923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x001D1608 File Offset: 0x001CF808
		[CallerCount(0)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006681 RID: 26241 RVA: 0x001D163C File Offset: 0x001CF83C
		[CallerCount(0)]
		public unsafe virtual void PurchaseOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006682 RID: 26242 RVA: 0x001D1688 File Offset: 0x001CF888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionListFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionListFeature>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006683 RID: 26243 RVA: 0x001D16C4 File Offset: 0x001CF8C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208946, RefRangeEnd = 208948, XrefRangeStart = 208923, XrefRangeEnd = 208946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006684 RID: 26244 RVA: 0x001D1700 File Offset: 0x001CF900
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006685 RID: 26245 RVA: 0x001D173C File Offset: 0x001CF93C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x001D1778 File Offset: 0x001CF978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208948, XrefRangeEnd = 208959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x001D17B8 File Offset: 0x001CF9B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208967, RefRangeEnd = 208969, XrefRangeStart = 208959, XrefRangeEnd = 208967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref colorIndex;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x001D1804 File Offset: 0x001CFA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208969, XrefRangeEnd = 208974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x001D1868 File Offset: 0x001CFA68
		// (set) Token: 0x0600668A RID: 26250 RVA: 0x001D18A4 File Offset: 0x001CFAA4
		public unsafe int SyncAccessor_ownedOptionIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208982, RefRangeEnd = 208983, XrefRangeStart = 208974, XrefRangeEnd = 208982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionListFeature.NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600668B RID: 26251 RVA: 0x001D18F0 File Offset: 0x001CFAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208983, XrefRangeEnd = 208988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x001D1964 File Offset: 0x001CFB64
		[CallerCount(0)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionListFeature.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x000303D5 File Offset: 0x0002E5D5
		public OptionListFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600668E RID: 26254 RVA: 0x001D19A0 File Offset: 0x001CFBA0
		// (set) Token: 0x0600668F RID: 26255 RVA: 0x000303DE File Offset: 0x0002E5DE
		public unsafe int defaultOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_defaultOptionIndex)) = value;
			}
		}

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x06006690 RID: 26256 RVA: 0x001D19C8 File Offset: 0x001CFBC8
		// (set) Token: 0x06006691 RID: 26257 RVA: 0x000303F9 File Offset: 0x0002E5F9
		public unsafe int ownedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_ownedOptionIndex)) = value;
			}
		}

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06006692 RID: 26258 RVA: 0x001D19F0 File Offset: 0x001CFBF0
		// (set) Token: 0x06006693 RID: 26259 RVA: 0x00030414 File Offset: 0x0002E614
		public unsafe SyncVar<int> syncVar___ownedOptionIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_syncVar___ownedOptionIndex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06006694 RID: 26260 RVA: 0x001D1A20 File Offset: 0x001CFC20
		// (set) Token: 0x06006695 RID: 26261 RVA: 0x00030433 File Offset: 0x0002E633
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06006696 RID: 26262 RVA: 0x001D1A48 File Offset: 0x001CFC48
		// (set) Token: 0x06006697 RID: 26263 RVA: 0x0003044E File Offset: 0x0002E64E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040045ED RID: 17901
		private static readonly IntPtr NativeFieldInfoPtr_defaultOptionIndex;

		// Token: 0x040045EE RID: 17902
		private static readonly IntPtr NativeFieldInfoPtr_ownedOptionIndex;

		// Token: 0x040045EF RID: 17903
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___ownedOptionIndex;

		// Token: 0x040045F0 RID: 17904
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040045F1 RID: 17905
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040045F2 RID: 17906
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040045F3 RID: 17907
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_FI_Base_Transform_0;

		// Token: 0x040045F4 RID: 17908
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x040045F5 RID: 17909
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Abstract_Virtual_New_List_1_Option_0;

		// Token: 0x040045F6 RID: 17910
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040045F7 RID: 17911
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040045F8 RID: 17912
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x040045F9 RID: 17913
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseOption_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040045FA RID: 17914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040045FB RID: 17915
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045FC RID: 17916
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045FD RID: 17917
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045FE RID: 17918
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_3316948804_Private_Void_Int32_0;

		// Token: 0x040045FF RID: 17919
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_3316948804_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04004600 RID: 17920
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004601 RID: 17921
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_ownedOptionIndex_Public_get_Int32_0;

		// Token: 0x04004602 RID: 17922
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_ownedOptionIndex_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04004603 RID: 17923
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Construction_Features_OptionListFeature_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04004604 RID: 17924
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
