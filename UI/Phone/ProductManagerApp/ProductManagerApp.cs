using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020006CD RID: 1741
	public class ProductManagerApp : App<ProductManagerApp>
	{
		// Token: 0x06009B06 RID: 39686 RVA: 0x0027AEDC File Offset: 0x002790DC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerApp()
		{
			Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductManagerApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr);
			ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "FavouritesContainer");
			ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "ProductTypeContainers");
			ProductManagerApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "DetailPanel");
			ProductManagerApp.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "SelectionIndicator");
			ProductManagerApp.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "EntryPrefab");
			ProductManagerApp.NativeFieldInfoPtr_favouriteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "favouriteEntries");
			ProductManagerApp.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "entries");
			ProductManagerApp.NativeFieldInfoPtr_selectedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "selectedEntry");
			ProductManagerApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682517);
			ProductManagerApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682518);
			ProductManagerApp.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682519);
			ProductManagerApp.NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682520);
			ProductManagerApp.NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682521);
			ProductManagerApp.NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682522);
			ProductManagerApp.NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682523);
			ProductManagerApp.NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682524);
			ProductManagerApp.NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682525);
			ProductManagerApp.NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682526);
			ProductManagerApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682527);
			ProductManagerApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682528);
			ProductManagerApp.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100682529);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x0027B0B0 File Offset: 0x002792B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276733, XrefRangeEnd = 276738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x0027B0EC File Offset: 0x002792EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276738, XrefRangeEnd = 276818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x0027B128 File Offset: 0x00279328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276818, XrefRangeEnd = 276826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x0027B15C File Offset: 0x0027935C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276826, XrefRangeEnd = 276867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x0027B1AC File Offset: 0x002793AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276867, XrefRangeEnd = 276868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavourited(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x0027B1F0 File Offset: 0x002793F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276868, XrefRangeEnd = 276869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductUnfavourited(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x0027B234 File Offset: 0x00279434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276903, RefRangeEnd = 276905, XrefRangeStart = 276869, XrefRangeEnd = 276903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateFavouriteEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x0027B278 File Offset: 0x00279478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276939, RefRangeEnd = 276940, XrefRangeStart = 276905, XrefRangeEnd = 276939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFavouriteEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x0027B2BC File Offset: 0x002794BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276946, RefRangeEnd = 276948, XrefRangeStart = 276940, XrefRangeEnd = 276946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedRebuildLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x0027B2F0 File Offset: 0x002794F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276956, RefRangeEnd = 276957, XrefRangeStart = 276948, XrefRangeEnd = 276956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectProduct(ProductEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0027B334 File Offset: 0x00279534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276957, XrefRangeEnd = 277014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x0027B380 File Offset: 0x00279580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277014, XrefRangeEnd = 277032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0027B3BC File Offset: 0x002795BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277032, XrefRangeEnd = 277037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x0004B470 File Offset: 0x00049670
		public ProductManagerApp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x06009B15 RID: 39701 RVA: 0x0027B3FC File Offset: 0x002795FC
		// (set) Token: 0x06009B16 RID: 39702 RVA: 0x0004B479 File Offset: 0x00049679
		public unsafe ProductManagerApp.ProductTypeContainer FavouritesContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp.ProductTypeContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x06009B17 RID: 39703 RVA: 0x0027B42C File Offset: 0x0027962C
		// (set) Token: 0x06009B18 RID: 39704 RVA: 0x0004B498 File Offset: 0x00049698
		public unsafe List<ProductManagerApp.ProductTypeContainer> ProductTypeContainers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductManagerApp.ProductTypeContainer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x06009B19 RID: 39705 RVA: 0x0027B45C File Offset: 0x0027965C
		// (set) Token: 0x06009B1A RID: 39706 RVA: 0x0004B4B7 File Offset: 0x000496B7
		public unsafe ProductAppDetailPanel DetailPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_DetailPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductAppDetailPanel>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x06009B1B RID: 39707 RVA: 0x0027B48C File Offset: 0x0027968C
		// (set) Token: 0x06009B1C RID: 39708 RVA: 0x0004B4D6 File Offset: 0x000496D6
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_SelectionIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x06009B1D RID: 39709 RVA: 0x0027B4BC File Offset: 0x002796BC
		// (set) Token: 0x06009B1E RID: 39710 RVA: 0x0004B4F5 File Offset: 0x000496F5
		public unsafe GameObject EntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_EntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x06009B1F RID: 39711 RVA: 0x0027B4EC File Offset: 0x002796EC
		// (set) Token: 0x06009B20 RID: 39712 RVA: 0x0004B514 File Offset: 0x00049714
		public unsafe List<ProductEntry> favouriteEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_favouriteEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_favouriteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x06009B21 RID: 39713 RVA: 0x0027B51C File Offset: 0x0027971C
		// (set) Token: 0x06009B22 RID: 39714 RVA: 0x0004B533 File Offset: 0x00049733
		public unsafe List<ProductEntry> entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x06009B23 RID: 39715 RVA: 0x0027B54C File Offset: 0x0027974C
		// (set) Token: 0x06009B24 RID: 39716 RVA: 0x0004B552 File Offset: 0x00049752
		public unsafe ProductEntry selectedEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_selectedEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductEntry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_selectedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400686B RID: 26731
		private static readonly System.IntPtr NativeFieldInfoPtr_FavouritesContainer;

		// Token: 0x0400686C RID: 26732
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductTypeContainers;

		// Token: 0x0400686D RID: 26733
		private static readonly System.IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x0400686E RID: 26734
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x0400686F RID: 26735
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04006870 RID: 26736
		private static readonly System.IntPtr NativeFieldInfoPtr_favouriteEntries;

		// Token: 0x04006871 RID: 26737
		private static readonly System.IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04006872 RID: 26738
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedEntry;

		// Token: 0x04006873 RID: 26739
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006874 RID: 26740
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006875 RID: 26741
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006876 RID: 26742
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0;

		// Token: 0x04006877 RID: 26743
		private static readonly System.IntPtr NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x04006878 RID: 26744
		private static readonly System.IntPtr NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0;

		// Token: 0x04006879 RID: 26745
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0;

		// Token: 0x0400687A RID: 26746
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0;

		// Token: 0x0400687B RID: 26747
		private static readonly System.IntPtr NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0;

		// Token: 0x0400687C RID: 26748
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0;

		// Token: 0x0400687D RID: 26749
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400687E RID: 26750
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400687F RID: 26751
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BBF RID: 3007
		[System.Serializable]
		public class ProductTypeContainer : Il2CppSystem.Object
		{
			// Token: 0x0600E02A RID: 57386 RVA: 0x00353C60 File Offset: 0x00351E60
			// Note: this type is marked as 'beforefieldinit'.
			static ProductTypeContainer()
			{
				Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "ProductTypeContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr);
				ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, "DrugType");
				ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, "Container");
				ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_NoneDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, "NoneDisplay");
				ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, 100682530);
				ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr, 100682531);
			}

			// Token: 0x0600E02B RID: 57387 RVA: 0x00353CF0 File Offset: 0x00351EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276664, XrefRangeEnd = 276668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RefreshNoneDisplay()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E02C RID: 57388 RVA: 0x00353D24 File Offset: 0x00351F24
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.ProductTypeContainer>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ProductTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E02D RID: 57389 RVA: 0x0006CDCA File Offset: 0x0006AFCA
			public ProductTypeContainer(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453C RID: 17724
			// (get) Token: 0x0600E02E RID: 57390 RVA: 0x00353D60 File Offset: 0x00351F60
			// (set) Token: 0x0600E02F RID: 57391 RVA: 0x0006CDD3 File Offset: 0x0006AFD3
			public unsafe EDrugType DrugType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x1700453D RID: 17725
			// (get) Token: 0x0600E030 RID: 57392 RVA: 0x00353D88 File Offset: 0x00351F88
			// (set) Token: 0x0600E031 RID: 57393 RVA: 0x0006CDEE File Offset: 0x0006AFEE
			public unsafe RectTransform Container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_Container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453E RID: 17726
			// (get) Token: 0x0600E032 RID: 57394 RVA: 0x00353DB8 File Offset: 0x00351FB8
			// (set) Token: 0x0600E033 RID: 57395 RVA: 0x0006CE0D File Offset: 0x0006B00D
			public unsafe RectTransform NoneDisplay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_NoneDisplay);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ProductTypeContainer.NativeFieldInfoPtr_NoneDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400967D RID: 38525
			private static readonly System.IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x0400967E RID: 38526
			private static readonly System.IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x0400967F RID: 38527
			private static readonly System.IntPtr NativeFieldInfoPtr_NoneDisplay;

			// Token: 0x04009680 RID: 38528
			private static readonly System.IntPtr NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0;

			// Token: 0x04009681 RID: 38529
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BC0 RID: 3008
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<<DelayedRebuildLayout>g__Delay|17_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E034 RID: 57396 RVA: 0x00353DE8 File Offset: 0x00351FE8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<<DelayedRebuildLayout>g__Delay|17_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682532);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682533);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682534);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682535);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682536);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100682537);
			}

			// Token: 0x0600E035 RID: 57397 RVA: 0x00353EC8 File Offset: 0x003520C8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E036 RID: 57398 RVA: 0x00353F10 File Offset: 0x00352110
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E037 RID: 57399 RVA: 0x00353F44 File Offset: 0x00352144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276668, XrefRangeEnd = 276681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004542 RID: 17730
			// (get) Token: 0x0600E038 RID: 57400 RVA: 0x00353F80 File Offset: 0x00352180
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E039 RID: 57401 RVA: 0x00353FC0 File Offset: 0x003521C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276681, XrefRangeEnd = 276686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004543 RID: 17731
			// (get) Token: 0x0600E03A RID: 57402 RVA: 0x00353FF4 File Offset: 0x003521F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E03B RID: 57403 RVA: 0x0006CE2C File Offset: 0x0006B02C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453F RID: 17727
			// (get) Token: 0x0600E03C RID: 57404 RVA: 0x00354034 File Offset: 0x00352234
			// (set) Token: 0x0600E03D RID: 57405 RVA: 0x0006CE35 File Offset: 0x0006B035
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004540 RID: 17728
			// (get) Token: 0x0600E03E RID: 57406 RVA: 0x0035405C File Offset: 0x0035225C
			// (set) Token: 0x0600E03F RID: 57407 RVA: 0x0006CE50 File Offset: 0x0006B050
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004541 RID: 17729
			// (get) Token: 0x0600E040 RID: 57408 RVA: 0x0035408C File Offset: 0x0035228C
			// (set) Token: 0x0600E041 RID: 57409 RVA: 0x0006CE6F File Offset: 0x0006B06F
			public unsafe ProductManagerApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009682 RID: 38530
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009683 RID: 38531
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009684 RID: 38532
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009685 RID: 38533
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009686 RID: 38534
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009687 RID: 38535
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009688 RID: 38536
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009689 RID: 38537
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400968A RID: 38538
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BC1 RID: 3009
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E042 RID: 57410 RVA: 0x003540BC File Offset: 0x003522BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass12_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr, 100682538);
				ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr, 100682539);
			}

			// Token: 0x0600E043 RID: 57411 RVA: 0x00354124 File Offset: 0x00352324
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E044 RID: 57412 RVA: 0x00354160 File Offset: 0x00352360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276686, XrefRangeEnd = 276689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateEntry_b__0(ProductManagerApp.ProductTypeContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass12_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E045 RID: 57413 RVA: 0x0006CE8E File Offset: 0x0006B08E
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004544 RID: 17732
			// (get) Token: 0x0600E046 RID: 57414 RVA: 0x003541B0 File Offset: 0x003523B0
			// (set) Token: 0x0600E047 RID: 57415 RVA: 0x0006CE97 File Offset: 0x0006B097
			public unsafe ProductDefinition definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass12_0.NativeFieldInfoPtr_definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass12_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400968B RID: 38539
			private static readonly System.IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x0400968C RID: 38540
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400968D RID: 38541
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0;
		}

		// Token: 0x02000BC2 RID: 3010
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E048 RID: 57416 RVA: 0x003541E0 File Offset: 0x003523E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass15_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr, 100682540);
				ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr, 100682541);
			}

			// Token: 0x0600E049 RID: 57417 RVA: 0x00354248 File Offset: 0x00352448
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass15_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E04A RID: 57418 RVA: 0x00354284 File Offset: 0x00352484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276689, XrefRangeEnd = 276694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateFavouriteEntry_b__0(ProductEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass15_0.NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E04B RID: 57419 RVA: 0x0006CEB6 File Offset: 0x0006B0B6
			public __c__DisplayClass15_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004545 RID: 17733
			// (get) Token: 0x0600E04C RID: 57420 RVA: 0x003542D4 File Offset: 0x003524D4
			// (set) Token: 0x0600E04D RID: 57421 RVA: 0x0006CEBF File Offset: 0x0006B0BF
			public unsafe ProductDefinition definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass15_0.NativeFieldInfoPtr_definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass15_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400968E RID: 38542
			private static readonly System.IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x0400968F RID: 38543
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009690 RID: 38544
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0;
		}

		// Token: 0x02000BC3 RID: 3011
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E04E RID: 57422 RVA: 0x00354304 File Offset: 0x00352504
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass16_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr, 100682542);
				ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr, 100682543);
			}

			// Token: 0x0600E04F RID: 57423 RVA: 0x0035436C File Offset: 0x0035256C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass16_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E050 RID: 57424 RVA: 0x003543A8 File Offset: 0x003525A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276694, XrefRangeEnd = 276699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFavouriteEntry_b__0(ProductEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass16_0.NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E051 RID: 57425 RVA: 0x0006CEDE File Offset: 0x0006B0DE
			public __c__DisplayClass16_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004546 RID: 17734
			// (get) Token: 0x0600E052 RID: 57426 RVA: 0x003543F8 File Offset: 0x003525F8
			// (set) Token: 0x0600E053 RID: 57427 RVA: 0x0006CEE7 File Offset: 0x0006B0E7
			public unsafe ProductDefinition definition
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass16_0.NativeFieldInfoPtr_definition);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass16_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009691 RID: 38545
			private static readonly System.IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x04009692 RID: 38546
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009693 RID: 38547
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0;
		}

		// Token: 0x02000BC4 RID: 3012
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E054 RID: 57428 RVA: 0x00354428 File Offset: 0x00352628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, "<>4__this");
				ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr_layoutGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, "layoutGroups");
				ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, 100682544);
				ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, 100682545);
			}

			// Token: 0x0600E055 RID: 57429 RVA: 0x003544A4 File Offset: 0x003526A4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E056 RID: 57430 RVA: 0x003544E0 File Offset: 0x003526E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276728, XrefRangeEnd = 276733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E057 RID: 57431 RVA: 0x0006CF06 File Offset: 0x0006B106
			public __c__DisplayClass19_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004547 RID: 17735
			// (get) Token: 0x0600E058 RID: 57432 RVA: 0x00354520 File Offset: 0x00352720
			// (set) Token: 0x0600E059 RID: 57433 RVA: 0x0006CF0F File Offset: 0x0006B10F
			public unsafe ProductManagerApp __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004548 RID: 17736
			// (get) Token: 0x0600E05A RID: 57434 RVA: 0x00354550 File Offset: 0x00352750
			// (set) Token: 0x0600E05B RID: 57435 RVA: 0x0006CF2E File Offset: 0x0006B12E
			public unsafe Il2CppReferenceArray<VerticalLayoutGroup> layoutGroups
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr_layoutGroups);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VerticalLayoutGroup>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.NativeFieldInfoPtr_layoutGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009694 RID: 38548
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009695 RID: 38549
			private static readonly System.IntPtr NativeFieldInfoPtr_layoutGroups;

			// Token: 0x04009696 RID: 38550
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009697 RID: 38551
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD9 RID: 3289
			[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass19_0+<<SetOpen>g__Delay|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EBD2 RID: 60370 RVA: 0x0037535C File Offset: 0x0037355C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0>.NativeClassPtr, "<<SetOpen>g__Delay|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682546);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682547);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682548);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682549);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682550);
					ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682551);
				}

				// Token: 0x0600EBD3 RID: 60371 RVA: 0x0037543C File Offset: 0x0037363C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBD4 RID: 60372 RVA: 0x00375484 File Offset: 0x00373684
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBD5 RID: 60373 RVA: 0x003754B8 File Offset: 0x003736B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276699, XrefRangeEnd = 276723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004914 RID: 18708
				// (get) Token: 0x0600EBD6 RID: 60374 RVA: 0x003754F4 File Offset: 0x003736F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBD7 RID: 60375 RVA: 0x00375534 File Offset: 0x00373734
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276723, XrefRangeEnd = 276728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004915 RID: 18709
				// (get) Token: 0x0600EBD8 RID: 60376 RVA: 0x00375568 File Offset: 0x00373768
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBD9 RID: 60377 RVA: 0x00072C64 File Offset: 0x00070E64
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004911 RID: 18705
				// (get) Token: 0x0600EBDA RID: 60378 RVA: 0x003755A8 File Offset: 0x003737A8
				// (set) Token: 0x0600EBDB RID: 60379 RVA: 0x00072C6D File Offset: 0x00070E6D
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004912 RID: 18706
				// (get) Token: 0x0600EBDC RID: 60380 RVA: 0x003755D0 File Offset: 0x003737D0
				// (set) Token: 0x0600EBDD RID: 60381 RVA: 0x00072C88 File Offset: 0x00070E88
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004913 RID: 18707
				// (get) Token: 0x0600EBDE RID: 60382 RVA: 0x00375600 File Offset: 0x00373800
				// (set) Token: 0x0600EBDF RID: 60383 RVA: 0x00072CA7 File Offset: 0x00070EA7
				public unsafe ProductManagerApp.__c__DisplayClass19_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp.__c__DisplayClass19_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009DAD RID: 40365
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009DAE RID: 40366
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DAF RID: 40367
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DB0 RID: 40368
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009DB1 RID: 40369
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DB2 RID: 40370
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009DB3 RID: 40371
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009DB4 RID: 40372
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DB5 RID: 40373
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
