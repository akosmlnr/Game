using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C3 RID: 1731
	public class CounterOfferProductSelector : MonoBehaviour
	{
		// Token: 0x06009974 RID: 39284 RVA: 0x00276308 File Offset: 0x00274508
		// Note: this type is marked as 'beforefieldinit'.
		static CounterOfferProductSelector()
		{
			Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterOfferProductSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr);
			CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ENTRIES_PER_PAGE");
			CounterOfferProductSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "Container");
			CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "SearchBar");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductContainer");
			CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "PageLabel");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductEntryPrefab");
			CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductPreviewed");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductSelected");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntries");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntriesDict");
			CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "searchTerm");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageIndex");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageCount");
			CounterOfferProductSelector.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "results");
			CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "lastPreviewedResult");
			CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682340);
			CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682341);
			CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682342);
			CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682343);
			CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682344);
			CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682345);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682346);
			CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682347);
			CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682348);
			CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682349);
			CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682350);
			CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682351);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682352);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682353);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682354);
			CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682355);
			CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100682356);
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x06009975 RID: 39285 RVA: 0x002765CC File Offset: 0x002747CC
		// (set) Token: 0x06009976 RID: 39286 RVA: 0x00276608 File Offset: 0x00274808
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 53388, RefRangeEnd = 53391, XrefRangeStart = 53388, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x00276648 File Offset: 0x00274848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274597, XrefRangeEnd = 274607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x0027667C File Offset: 0x0027487C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274607, XrefRangeEnd = 274626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x002766B0 File Offset: 0x002748B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274626, XrefRangeEnd = 274629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x002766E4 File Offset: 0x002748E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274629, XrefRangeEnd = 274638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00276718 File Offset: 0x00274918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274638, XrefRangeEnd = 274650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSearchTerm(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x0027675C File Offset: 0x0027495C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274686, RefRangeEnd = 274689, XrefRangeStart = 274650, XrefRangeEnd = 274686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildResultsList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00276790 File Offset: 0x00274990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274784, RefRangeEnd = 274785, XrefRangeStart = 274689, XrefRangeEnd = 274784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x002767E0 File Offset: 0x002749E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274807, RefRangeEnd = 274809, XrefRangeStart = 274785, XrefRangeEnd = 274807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureAllEntriesExist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x00276814 File Offset: 0x00274A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274871, RefRangeEnd = 274872, XrefRangeStart = 274809, XrefRangeEnd = 274871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateProductEntry(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x00276858 File Offset: 0x00274A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274872, XrefRangeEnd = 274873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePage(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x00276898 File Offset: 0x00274A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274941, RefRangeEnd = 274943, XrefRangeStart = 274873, XrefRangeEnd = 274941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPage(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref page;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x002768D8 File Offset: 0x00274AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274943, XrefRangeEnd = 274944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductHovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x0027691C File Offset: 0x00274B1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274947, RefRangeEnd = 274948, XrefRangeStart = 274944, XrefRangeEnd = 274947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductSelected(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x00276960 File Offset: 0x00274B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274948, XrefRangeEnd = 274970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009985 RID: 39301 RVA: 0x0027699C File Offset: 0x00274B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274970, XrefRangeEnd = 274995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterOfferProductSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x0004A517 File Offset: 0x00048717
		public CounterOfferProductSelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x06009987 RID: 39303 RVA: 0x002769D8 File Offset: 0x00274BD8
		// (set) Token: 0x06009988 RID: 39304 RVA: 0x0004A520 File Offset: 0x00048720
		public unsafe static int ENTRIES_PER_PAGE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&value));
			}
		}

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x06009989 RID: 39305 RVA: 0x002769F4 File Offset: 0x00274BF4
		// (set) Token: 0x0600998A RID: 39306 RVA: 0x0004A52E File Offset: 0x0004872E
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600998B RID: 39307 RVA: 0x00276A24 File Offset: 0x00274C24
		// (set) Token: 0x0600998C RID: 39308 RVA: 0x0004A54D File Offset: 0x0004874D
		public unsafe InputField SearchBar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600998D RID: 39309 RVA: 0x00276A54 File Offset: 0x00274C54
		// (set) Token: 0x0600998E RID: 39310 RVA: 0x0004A56C File Offset: 0x0004876C
		public unsafe RectTransform ProductContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x00276A84 File Offset: 0x00274C84
		// (set) Token: 0x06009990 RID: 39312 RVA: 0x0004A58B File Offset: 0x0004878B
		public unsafe Text PageLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x06009991 RID: 39313 RVA: 0x00276AB4 File Offset: 0x00274CB4
		// (set) Token: 0x06009992 RID: 39314 RVA: 0x0004A5AA File Offset: 0x000487AA
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x00276AE4 File Offset: 0x00274CE4
		// (set) Token: 0x06009994 RID: 39316 RVA: 0x0004A5C9 File Offset: 0x000487C9
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x06009995 RID: 39317 RVA: 0x00276B0C File Offset: 0x00274D0C
		// (set) Token: 0x06009996 RID: 39318 RVA: 0x0004A5E4 File Offset: 0x000487E4
		public unsafe Il2CppSystem.Action<ProductDefinition> onProductPreviewed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x06009997 RID: 39319 RVA: 0x00276B3C File Offset: 0x00274D3C
		// (set) Token: 0x06009998 RID: 39320 RVA: 0x0004A603 File Offset: 0x00048803
		public unsafe Il2CppSystem.Action<ProductDefinition> onProductSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE3 RID: 12003
		// (get) Token: 0x06009999 RID: 39321 RVA: 0x00276B6C File Offset: 0x00274D6C
		// (set) Token: 0x0600999A RID: 39322 RVA: 0x0004A622 File Offset: 0x00048822
		public unsafe List<RectTransform> productEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE4 RID: 12004
		// (get) Token: 0x0600999B RID: 39323 RVA: 0x00276B9C File Offset: 0x00274D9C
		// (set) Token: 0x0600999C RID: 39324 RVA: 0x0004A641 File Offset: 0x00048841
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntriesDict
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE5 RID: 12005
		// (get) Token: 0x0600999D RID: 39325 RVA: 0x00276BCC File Offset: 0x00274DCC
		// (set) Token: 0x0600999E RID: 39326 RVA: 0x0004A660 File Offset: 0x00048860
		public unsafe string searchTerm
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002EE6 RID: 12006
		// (get) Token: 0x0600999F RID: 39327 RVA: 0x00276BF4 File Offset: 0x00274DF4
		// (set) Token: 0x060099A0 RID: 39328 RVA: 0x0004A67F File Offset: 0x0004887F
		public unsafe int pageIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex)) = value;
			}
		}

		// Token: 0x17002EE7 RID: 12007
		// (get) Token: 0x060099A1 RID: 39329 RVA: 0x00276C1C File Offset: 0x00274E1C
		// (set) Token: 0x060099A2 RID: 39330 RVA: 0x0004A69A File Offset: 0x0004889A
		public unsafe int pageCount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x17002EE8 RID: 12008
		// (get) Token: 0x060099A3 RID: 39331 RVA: 0x00276C44 File Offset: 0x00274E44
		// (set) Token: 0x060099A4 RID: 39332 RVA: 0x0004A6B5 File Offset: 0x000488B5
		public unsafe List<ProductDefinition> results
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002EE9 RID: 12009
		// (get) Token: 0x060099A5 RID: 39333 RVA: 0x00276C74 File Offset: 0x00274E74
		// (set) Token: 0x060099A6 RID: 39334 RVA: 0x0004A6D4 File Offset: 0x000488D4
		public unsafe ProductDefinition lastPreviewedResult
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400676E RID: 26478
		private static readonly System.IntPtr NativeFieldInfoPtr_ENTRIES_PER_PAGE;

		// Token: 0x0400676F RID: 26479
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006770 RID: 26480
		private static readonly System.IntPtr NativeFieldInfoPtr_SearchBar;

		// Token: 0x04006771 RID: 26481
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x04006772 RID: 26482
		private static readonly System.IntPtr NativeFieldInfoPtr_PageLabel;

		// Token: 0x04006773 RID: 26483
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x04006774 RID: 26484
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006775 RID: 26485
		private static readonly System.IntPtr NativeFieldInfoPtr_onProductPreviewed;

		// Token: 0x04006776 RID: 26486
		private static readonly System.IntPtr NativeFieldInfoPtr_onProductSelected;

		// Token: 0x04006777 RID: 26487
		private static readonly System.IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x04006778 RID: 26488
		private static readonly System.IntPtr NativeFieldInfoPtr_productEntriesDict;

		// Token: 0x04006779 RID: 26489
		private static readonly System.IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x0400677A RID: 26490
		private static readonly System.IntPtr NativeFieldInfoPtr_pageIndex;

		// Token: 0x0400677B RID: 26491
		private static readonly System.IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x0400677C RID: 26492
		private static readonly System.IntPtr NativeFieldInfoPtr_results;

		// Token: 0x0400677D RID: 26493
		private static readonly System.IntPtr NativeFieldInfoPtr_lastPreviewedResult;

		// Token: 0x0400677E RID: 26494
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400677F RID: 26495
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006780 RID: 26496
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04006781 RID: 26497
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006782 RID: 26498
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006783 RID: 26499
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006784 RID: 26500
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0;

		// Token: 0x04006785 RID: 26501
		private static readonly System.IntPtr NativeMethodInfoPtr_RebuildResultsList_Private_Void_0;

		// Token: 0x04006786 RID: 26502
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0;

		// Token: 0x04006787 RID: 26503
		private static readonly System.IntPtr NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0;

		// Token: 0x04006788 RID: 26504
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0;

		// Token: 0x04006789 RID: 26505
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0;

		// Token: 0x0400678A RID: 26506
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPage_Private_Void_Int32_0;

		// Token: 0x0400678B RID: 26507
		private static readonly System.IntPtr NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0;

		// Token: 0x0400678C RID: 26508
		private static readonly System.IntPtr NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0;

		// Token: 0x0400678D RID: 26509
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0;

		// Token: 0x0400678E RID: 26510
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB2 RID: 2994
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DF93 RID: 57235 RVA: 0x00352258 File Offset: 0x00350458
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr);
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9");
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9__24_0");
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100682358);
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100682359);
			}

			// Token: 0x0600DF94 RID: 57236 RVA: 0x003522D4 File Offset: 0x003504D4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF95 RID: 57237 RVA: 0x00352310 File Offset: 0x00350510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274584, XrefRangeEnd = 274592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RebuildResultsList_b__24_0(ProductDefinition a, ProductDefinition b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DF96 RID: 57238 RVA: 0x0006C89F File Offset: 0x0006AA9F
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004509 RID: 17673
			// (get) Token: 0x0600DF97 RID: 57239 RVA: 0x00352370 File Offset: 0x00350570
			// (set) Token: 0x0600DF98 RID: 57240 RVA: 0x0006C8A8 File Offset: 0x0006AAA8
			public unsafe static CounterOfferProductSelector.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450A RID: 17674
			// (get) Token: 0x0600DF99 RID: 57241 RVA: 0x00352398 File Offset: 0x00350598
			// (set) Token: 0x0600DF9A RID: 57242 RVA: 0x0006C8BA File Offset: 0x0006AABA
			public unsafe static Il2CppSystem.Comparison<ProductDefinition> __9__24_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009629 RID: 38441
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400962A RID: 38442
			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400962B RID: 38443
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400962C RID: 38444
			private static readonly System.IntPtr NativeMethodInfoPtr__RebuildResultsList_b__24_0_Internal_Int32_ProductDefinition_ProductDefinition_0;
		}

		// Token: 0x02000BB3 RID: 2995
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF9B RID: 57243 RVA: 0x003523C0 File Offset: 0x003505C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, "product");
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100682360);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100682361);
				CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr, 100682362);
			}

			// Token: 0x0600DF9C RID: 57244 RVA: 0x00352450 File Offset: 0x00350650
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass27_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF9D RID: 57245 RVA: 0x0035248C File Offset: 0x0035068C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274592, XrefRangeEnd = 274595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF9E RID: 57246 RVA: 0x003524C0 File Offset: 0x003506C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274595, XrefRangeEnd = 274597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass27_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF9F RID: 57247 RVA: 0x0006C8CC File Offset: 0x0006AACC
			public __c__DisplayClass27_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450B RID: 17675
			// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x00352504 File Offset: 0x00350704
			// (set) Token: 0x0600DFA1 RID: 57249 RVA: 0x0006C8D5 File Offset: 0x0006AAD5
			public unsafe CounterOfferProductSelector __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450C RID: 17676
			// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x00352534 File Offset: 0x00350734
			// (set) Token: 0x0600DFA3 RID: 57251 RVA: 0x0006C8F4 File Offset: 0x0006AAF4
			public unsafe ProductDefinition product
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass27_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400962D RID: 38445
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400962E RID: 38446
			private static readonly System.IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400962F RID: 38447
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009630 RID: 38448
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0;

			// Token: 0x04009631 RID: 38449
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0;
		}
	}
}
