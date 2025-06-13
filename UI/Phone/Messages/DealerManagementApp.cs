using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D3 RID: 1747
	public class DealerManagementApp : App<DealerManagementApp>
	{
		// Token: 0x06009C0B RID: 39947 RVA: 0x0027DFAC File Offset: 0x0027C1AC
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementApp()
		{
			Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealerManagementApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr);
			DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<SelectedDealer>k__BackingField");
			DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NoDealersLabel");
			DealerManagementApp.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "Content");
			DealerManagementApp.NativeFieldInfoPtr_CustomerSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerSelector");
			DealerManagementApp.NativeFieldInfoPtr_SelectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorImage");
			DealerManagementApp.NativeFieldInfoPtr_SelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorTitle");
			DealerManagementApp.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "BackButton");
			DealerManagementApp.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NextButton");
			DealerManagementApp.NativeFieldInfoPtr_CashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CashLabel");
			DealerManagementApp.NativeFieldInfoPtr_CutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CutLabel");
			DealerManagementApp.NativeFieldInfoPtr_HomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "HomeLabel");
			DealerManagementApp.NativeFieldInfoPtr_InventoryEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "InventoryEntries");
			DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerTitleLabel");
			DealerManagementApp.NativeFieldInfoPtr_CustomerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerEntries");
			DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "AssignCustomerButton");
			DealerManagementApp.NativeFieldInfoPtr_dealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "dealers");
			DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682639);
			DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682640);
			DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682641);
			DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682642);
			DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682643);
			DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682644);
			DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682645);
			DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682646);
			DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682647);
			DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682648);
			DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682649);
			DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682650);
			DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682651);
			DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100682652);
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x06009C0C RID: 39948 RVA: 0x0027E234 File Offset: 0x0027C434
		// (set) Token: 0x06009C0D RID: 39949 RVA: 0x0027E274 File Offset: 0x0027C474
		public unsafe Dealer SelectedDealer
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 24360, RefRangeEnd = 24376, XrefRangeStart = 24360, XrefRangeEnd = 24376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009C0E RID: 39950 RVA: 0x0027E2B8 File Offset: 0x0027C4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278121, XrefRangeEnd = 278181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C0F RID: 39951 RVA: 0x0027E2F4 File Offset: 0x0027C4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278181, XrefRangeEnd = 278194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C10 RID: 39952 RVA: 0x0027E330 File Offset: 0x0027C530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278194, XrefRangeEnd = 278219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C11 RID: 39953 RVA: 0x0027E36C File Offset: 0x0027C56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278219, XrefRangeEnd = 278238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x0027E3B8 File Offset: 0x0027C5B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 278399, RefRangeEnd = 278405, XrefRangeStart = 278238, XrefRangeEnd = 278399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x0027E3FC File Offset: 0x0027C5FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278435, RefRangeEnd = 278436, XrefRangeStart = 278405, XrefRangeEnd = 278435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C14 RID: 39956 RVA: 0x0027E440 File Offset: 0x0027C640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278436, XrefRangeEnd = 278445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C15 RID: 39957 RVA: 0x0027E484 File Offset: 0x0027C684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278445, XrefRangeEnd = 278448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C16 RID: 39958 RVA: 0x0027E4C8 File Offset: 0x0027C6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278448, XrefRangeEnd = 278455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C17 RID: 39959 RVA: 0x0027E4FC File Offset: 0x0027C6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278455, XrefRangeEnd = 278463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C18 RID: 39960 RVA: 0x0027E530 File Offset: 0x0027C730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278463, XrefRangeEnd = 278465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCustomer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C19 RID: 39961 RVA: 0x0027E564 File Offset: 0x0027C764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278465, XrefRangeEnd = 278478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009C1A RID: 39962 RVA: 0x0004BE26 File Offset: 0x0004A026
		public DealerManagementApp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x06009C1B RID: 39963 RVA: 0x0027E5A0 File Offset: 0x0027C7A0
		// (set) Token: 0x06009C1C RID: 39964 RVA: 0x0004BE2F File Offset: 0x0004A02F
		public unsafe Dealer _SelectedDealer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC3 RID: 12227
		// (get) Token: 0x06009C1D RID: 39965 RVA: 0x0027E5D0 File Offset: 0x0027C7D0
		// (set) Token: 0x06009C1E RID: 39966 RVA: 0x0004BE4E File Offset: 0x0004A04E
		public unsafe Text NoDealersLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC4 RID: 12228
		// (get) Token: 0x06009C1F RID: 39967 RVA: 0x0027E600 File Offset: 0x0027C800
		// (set) Token: 0x06009C20 RID: 39968 RVA: 0x0004BE6D File Offset: 0x0004A06D
		public unsafe RectTransform Content
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC5 RID: 12229
		// (get) Token: 0x06009C21 RID: 39969 RVA: 0x0027E630 File Offset: 0x0027C830
		// (set) Token: 0x06009C22 RID: 39970 RVA: 0x0004BE8C File Offset: 0x0004A08C
		public unsafe CustomerSelector CustomerSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC6 RID: 12230
		// (get) Token: 0x06009C23 RID: 39971 RVA: 0x0027E660 File Offset: 0x0027C860
		// (set) Token: 0x06009C24 RID: 39972 RVA: 0x0004BEAB File Offset: 0x0004A0AB
		public unsafe Image SelectorImage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC7 RID: 12231
		// (get) Token: 0x06009C25 RID: 39973 RVA: 0x0027E690 File Offset: 0x0027C890
		// (set) Token: 0x06009C26 RID: 39974 RVA: 0x0004BECA File Offset: 0x0004A0CA
		public unsafe Text SelectorTitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06009C27 RID: 39975 RVA: 0x0027E6C0 File Offset: 0x0027C8C0
		// (set) Token: 0x06009C28 RID: 39976 RVA: 0x0004BEE9 File Offset: 0x0004A0E9
		public unsafe Button BackButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x06009C29 RID: 39977 RVA: 0x0027E6F0 File Offset: 0x0027C8F0
		// (set) Token: 0x06009C2A RID: 39978 RVA: 0x0004BF08 File Offset: 0x0004A108
		public unsafe Button NextButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x06009C2B RID: 39979 RVA: 0x0027E720 File Offset: 0x0027C920
		// (set) Token: 0x06009C2C RID: 39980 RVA: 0x0004BF27 File Offset: 0x0004A127
		public unsafe Text CashLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x06009C2D RID: 39981 RVA: 0x0027E750 File Offset: 0x0027C950
		// (set) Token: 0x06009C2E RID: 39982 RVA: 0x0004BF46 File Offset: 0x0004A146
		public unsafe Text CutLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x06009C2F RID: 39983 RVA: 0x0027E780 File Offset: 0x0027C980
		// (set) Token: 0x06009C30 RID: 39984 RVA: 0x0004BF65 File Offset: 0x0004A165
		public unsafe Text HomeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x06009C31 RID: 39985 RVA: 0x0027E7B0 File Offset: 0x0027C9B0
		// (set) Token: 0x06009C32 RID: 39986 RVA: 0x0004BF84 File Offset: 0x0004A184
		public unsafe Il2CppReferenceArray<RectTransform> InventoryEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x06009C33 RID: 39987 RVA: 0x0027E7E0 File Offset: 0x0027C9E0
		// (set) Token: 0x06009C34 RID: 39988 RVA: 0x0004BFA3 File Offset: 0x0004A1A3
		public unsafe Text CustomerTitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x06009C35 RID: 39989 RVA: 0x0027E810 File Offset: 0x0027CA10
		// (set) Token: 0x06009C36 RID: 39990 RVA: 0x0004BFC2 File Offset: 0x0004A1C2
		public unsafe Il2CppReferenceArray<RectTransform> CustomerEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x06009C37 RID: 39991 RVA: 0x0027E840 File Offset: 0x0027CA40
		// (set) Token: 0x06009C38 RID: 39992 RVA: 0x0004BFE1 File Offset: 0x0004A1E1
		public unsafe Button AssignCustomerButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x06009C39 RID: 39993 RVA: 0x0027E870 File Offset: 0x0027CA70
		// (set) Token: 0x06009C3A RID: 39994 RVA: 0x0004C000 File Offset: 0x0004A200
		public unsafe List<Dealer> dealers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006911 RID: 26897
		private static readonly System.IntPtr NativeFieldInfoPtr__SelectedDealer_k__BackingField;

		// Token: 0x04006912 RID: 26898
		private static readonly System.IntPtr NativeFieldInfoPtr_NoDealersLabel;

		// Token: 0x04006913 RID: 26899
		private static readonly System.IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04006914 RID: 26900
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerSelector;

		// Token: 0x04006915 RID: 26901
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectorImage;

		// Token: 0x04006916 RID: 26902
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectorTitle;

		// Token: 0x04006917 RID: 26903
		private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006918 RID: 26904
		private static readonly System.IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x04006919 RID: 26905
		private static readonly System.IntPtr NativeFieldInfoPtr_CashLabel;

		// Token: 0x0400691A RID: 26906
		private static readonly System.IntPtr NativeFieldInfoPtr_CutLabel;

		// Token: 0x0400691B RID: 26907
		private static readonly System.IntPtr NativeFieldInfoPtr_HomeLabel;

		// Token: 0x0400691C RID: 26908
		private static readonly System.IntPtr NativeFieldInfoPtr_InventoryEntries;

		// Token: 0x0400691D RID: 26909
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerTitleLabel;

		// Token: 0x0400691E RID: 26910
		private static readonly System.IntPtr NativeFieldInfoPtr_CustomerEntries;

		// Token: 0x0400691F RID: 26911
		private static readonly System.IntPtr NativeFieldInfoPtr_AssignCustomerButton;

		// Token: 0x04006920 RID: 26912
		private static readonly System.IntPtr NativeFieldInfoPtr_dealers;

		// Token: 0x04006921 RID: 26913
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0;

		// Token: 0x04006922 RID: 26914
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0;

		// Token: 0x04006923 RID: 26915
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006924 RID: 26916
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006925 RID: 26917
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006926 RID: 26918
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006927 RID: 26919
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0;

		// Token: 0x04006928 RID: 26920
		private static readonly System.IntPtr NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0;

		// Token: 0x04006929 RID: 26921
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0;

		// Token: 0x0400692A RID: 26922
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0;

		// Token: 0x0400692B RID: 26923
		private static readonly System.IntPtr NativeMethodInfoPtr_BackPressed_Private_Void_0;

		// Token: 0x0400692C RID: 26924
		private static readonly System.IntPtr NativeMethodInfoPtr_NextPressed_Private_Void_0;

		// Token: 0x0400692D RID: 26925
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignCustomer_Public_Void_0;

		// Token: 0x0400692E RID: 26926
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BCA RID: 3018
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E080 RID: 57472 RVA: 0x00354BC8 File Offset: 0x00352DC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr);
				DealerManagementApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9");
				DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9__24_0");
				DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100682654);
				DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100682655);
			}

			// Token: 0x0600E081 RID: 57473 RVA: 0x00354C44 File Offset: 0x00352E44
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E082 RID: 57474 RVA: 0x00354C80 File Offset: 0x00352E80
			[CallerCount(0)]
			public unsafe string _AddDealer_b__24_0(Dealer d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600E083 RID: 57475 RVA: 0x0006D050 File Offset: 0x0006B250
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004551 RID: 17745
			// (get) Token: 0x0600E084 RID: 57476 RVA: 0x00354CC8 File Offset: 0x00352EC8
			// (set) Token: 0x0600E085 RID: 57477 RVA: 0x0006D059 File Offset: 0x0006B259
			public unsafe static DealerManagementApp.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004552 RID: 17746
			// (get) Token: 0x0600E086 RID: 57478 RVA: 0x00354CF0 File Offset: 0x00352EF0
			// (set) Token: 0x0600E087 RID: 57479 RVA: 0x0006D06B File Offset: 0x0006B26B
			public unsafe static Il2CppSystem.Func<Dealer, string> __9__24_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Dealer, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096AA RID: 38570
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040096AB RID: 38571
			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x040096AC RID: 38572
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096AD RID: 38573
			private static readonly System.IntPtr NativeMethodInfoPtr__AddDealer_b__24_0_Internal_String_Dealer_0;
		}

		// Token: 0x02000BCB RID: 3019
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E088 RID: 57480 RVA: 0x00354D18 File Offset: 0x00352F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr);
				DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, "customer");
				DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, 100682656);
				DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr, 100682657);
			}

			// Token: 0x0600E089 RID: 57481 RVA: 0x00354D94 File Offset: 0x00352F94
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass23_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E08A RID: 57482 RVA: 0x00354DD0 File Offset: 0x00352FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278118, XrefRangeEnd = 278121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetDisplayedDealer_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass23_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E08B RID: 57483 RVA: 0x0006D07D File Offset: 0x0006B27D
			public __c__DisplayClass23_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004553 RID: 17747
			// (get) Token: 0x0600E08C RID: 57484 RVA: 0x00354E04 File Offset: 0x00353004
			// (set) Token: 0x0600E08D RID: 57485 RVA: 0x0006D086 File Offset: 0x0006B286
			public unsafe Customer customer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004554 RID: 17748
			// (get) Token: 0x0600E08E RID: 57486 RVA: 0x00354E34 File Offset: 0x00353034
			// (set) Token: 0x0600E08F RID: 57487 RVA: 0x0006D0A5 File Offset: 0x0006B2A5
			public unsafe DealerManagementApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096AE RID: 38574
			private static readonly System.IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x040096AF RID: 38575
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096B0 RID: 38576
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096B1 RID: 38577
			private static readonly System.IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Void_0;
		}
	}
}
