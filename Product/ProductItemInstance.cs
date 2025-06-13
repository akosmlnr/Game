using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005CA RID: 1482
	[System.Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x060080A3 RID: 32931 RVA: 0x002287B4 File Offset: 0x002269B4
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInstance()
		{
			Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr);
			ProductItemInstance.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "PackagingID");
			ProductItemInstance.NativeFieldInfoPtr_packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "packaging");
			ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679483);
			ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679484);
			ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679485);
			ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679486);
			ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679487);
			ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679488);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679489);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679490);
			ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679491);
			ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679492);
			ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679493);
			ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679494);
			ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679495);
			ProductItemInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679496);
			ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679497);
			ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679498);
			ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679499);
			ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679500);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679501);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679502);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679503);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679504);
			ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679505);
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x060080A4 RID: 32932 RVA: 0x002289D8 File Offset: 0x00226BD8
		public unsafe PackagingDefinition AppliedPackaging
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 243093, RefRangeEnd = 243141, XrefRangeStart = 243068, XrefRangeEnd = 243093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x060080A5 RID: 32933 RVA: 0x00228A18 File Offset: 0x00226C18
		public unsafe int Amount
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 243147, RefRangeEnd = 243165, XrefRangeStart = 243141, XrefRangeEnd = 243147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x060080A6 RID: 32934 RVA: 0x00228A54 File Offset: 0x00226C54
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243165, XrefRangeEnd = 243176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x060080A7 RID: 32935 RVA: 0x00228A98 File Offset: 0x00226C98
		public unsafe override Equippable Equippable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243176, XrefRangeEnd = 243183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x060080A8 RID: 32936 RVA: 0x00228AE4 File Offset: 0x00226CE4
		public unsafe override StoredItem StoredItem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243183, XrefRangeEnd = 243190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x060080A9 RID: 32937 RVA: 0x00228B30 File Offset: 0x00226D30
		public unsafe override Sprite Icon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243190, XrefRangeEnd = 243202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x00228B7C File Offset: 0x00226D7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 242197, RefRangeEnd = 242202, XrefRangeStart = 242197, XrefRangeEnd = 242202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x00228BB8 File Offset: 0x00226DB8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 243215, RefRangeEnd = 243227, XrefRangeStart = 243202, XrefRangeEnd = 243215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quality;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_packaging);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x00228C34 File Offset: 0x00226E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243227, XrefRangeEnd = 243249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref checkQuantities;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x00228C9C File Offset: 0x00226E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243249, XrefRangeEnd = 243255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref overrideQuantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x00228CF4 File Offset: 0x00226EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243255, XrefRangeEnd = 243264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPackaging(PackagingDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x00228D44 File Offset: 0x00226F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable GetEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x00228D84 File Offset: 0x00226F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem GetStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x00228DC4 File Offset: 0x00226FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243266, RefRangeEnd = 243267, XrefRangeStart = 243264, XrefRangeEnd = 243266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupPackagingVisuals(FilledPackagingVisuals visuals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visuals);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x00228E14 File Offset: 0x00227014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243267, XrefRangeEnd = 243279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x00228E54 File Offset: 0x00227054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243279, XrefRangeEnd = 243286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x060080B4 RID: 32948 RVA: 0x00228EA0 File Offset: 0x002270A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243286, XrefRangeEnd = 243294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060080B5 RID: 32949 RVA: 0x00228EE8 File Offset: 0x002270E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243317, RefRangeEnd = 243318, XrefRangeStart = 243294, XrefRangeEnd = 243317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSimilarity(ProductDefinition other, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quality;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x00228F44 File Offset: 0x00227144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243356, RefRangeEnd = 243359, XrefRangeStart = 243318, XrefRangeEnd = 243356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x00228F94 File Offset: 0x00227194
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243397, RefRangeEnd = 243400, XrefRangeStart = 243359, XrefRangeEnd = 243397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x00228FE4 File Offset: 0x002271E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243438, RefRangeEnd = 243441, XrefRangeStart = 243400, XrefRangeEnd = 243438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x00229034 File Offset: 0x00227234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243479, RefRangeEnd = 243482, XrefRangeStart = 243441, XrefRangeEnd = 243479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x00229084 File Offset: 0x00227284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243482, XrefRangeEnd = 243490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x0003CE1B File Offset: 0x0003B01B
		public ProductItemInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x060080BC RID: 32956 RVA: 0x002290CC File Offset: 0x002272CC
		// (set) Token: 0x060080BD RID: 32957 RVA: 0x0003CE24 File Offset: 0x0003B024
		public unsafe string PackagingID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x060080BE RID: 32958 RVA: 0x002290F4 File Offset: 0x002272F4
		// (set) Token: 0x060080BF RID: 32959 RVA: 0x0003CE43 File Offset: 0x0003B043
		public unsafe PackagingDefinition packaging
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005790 RID: 22416
		private static readonly System.IntPtr NativeFieldInfoPtr_PackagingID;

		// Token: 0x04005791 RID: 22417
		private static readonly System.IntPtr NativeFieldInfoPtr_packaging;

		// Token: 0x04005792 RID: 22418
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0;

		// Token: 0x04005793 RID: 22419
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Amount_Public_get_Int32_0;

		// Token: 0x04005794 RID: 22420
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04005795 RID: 22421
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0;

		// Token: 0x04005796 RID: 22422
		private static readonly System.IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0;

		// Token: 0x04005797 RID: 22423
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0;

		// Token: 0x04005798 RID: 22424
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005799 RID: 22425
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x0400579A RID: 22426
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0;

		// Token: 0x0400579B RID: 22427
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x0400579C RID: 22428
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0;

		// Token: 0x0400579D RID: 22429
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEquippable_Private_Equippable_0;

		// Token: 0x0400579E RID: 22430
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0;

		// Token: 0x0400579F RID: 22431
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupPackagingVisuals_Public_Virtual_New_Void_FilledPackagingVisuals_0;

		// Token: 0x040057A0 RID: 22432
		private static readonly System.IntPtr NativeMethodInfoPtr_GetIcon_Private_Sprite_0;

		// Token: 0x040057A1 RID: 22433
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x040057A2 RID: 22434
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0;

		// Token: 0x040057A3 RID: 22435
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x040057A4 RID: 22436
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x040057A5 RID: 22437
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x040057A6 RID: 22438
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x040057A7 RID: 22439
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x040057A8 RID: 22440
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;

		// Token: 0x02000B19 RID: 2841
		[ObfuscatedName("ScheduleOne.Product.ProductItemInstance+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D97D RID: 55677 RVA: 0x0034096C File Offset: 0x0033EB6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr);
				ProductItemInstance.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__26_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__27_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__28_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__29_0");
				ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679507);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679508);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679509);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679510);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679511);
			}

			// Token: 0x0600D97E RID: 55678 RVA: 0x00340A60 File Offset: 0x0033EC60
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D97F RID: 55679 RVA: 0x00340A9C File Offset: 0x0033EC9C
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToNPC_b__26_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D980 RID: 55680 RVA: 0x00340AEC File Offset: 0x0033ECEC
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromNPC_b__27_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D981 RID: 55681 RVA: 0x00340B3C File Offset: 0x0033ED3C
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToPlayer_b__28_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D982 RID: 55682 RVA: 0x00340B8C File Offset: 0x0033ED8C
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromPlayer_b__29_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D983 RID: 55683 RVA: 0x0006987D File Offset: 0x00067A7D
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700431C RID: 17180
			// (get) Token: 0x0600D984 RID: 55684 RVA: 0x00340BDC File Offset: 0x0033EDDC
			// (set) Token: 0x0600D985 RID: 55685 RVA: 0x00069886 File Offset: 0x00067A86
			public unsafe static ProductItemInstance.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431D RID: 17181
			// (get) Token: 0x0600D986 RID: 55686 RVA: 0x00340C04 File Offset: 0x0033EE04
			// (set) Token: 0x0600D987 RID: 55687 RVA: 0x00069898 File Offset: 0x00067A98
			public unsafe static Il2CppSystem.Func<Property, int> __9__26_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431E RID: 17182
			// (get) Token: 0x0600D988 RID: 55688 RVA: 0x00340C2C File Offset: 0x0033EE2C
			// (set) Token: 0x0600D989 RID: 55689 RVA: 0x000698AA File Offset: 0x00067AAA
			public unsafe static Il2CppSystem.Func<Property, int> __9__27_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700431F RID: 17183
			// (get) Token: 0x0600D98A RID: 55690 RVA: 0x00340C54 File Offset: 0x0033EE54
			// (set) Token: 0x0600D98B RID: 55691 RVA: 0x000698BC File Offset: 0x00067ABC
			public unsafe static Il2CppSystem.Func<Property, int> __9__28_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004320 RID: 17184
			// (get) Token: 0x0600D98C RID: 55692 RVA: 0x00340C7C File Offset: 0x0033EE7C
			// (set) Token: 0x0600D98D RID: 55693 RVA: 0x000698CE File Offset: 0x00067ACE
			public unsafe static Il2CppSystem.Func<Property, int> __9__29_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Property, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009279 RID: 37497
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400927A RID: 37498
			private static readonly System.IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x0400927B RID: 37499
			private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x0400927C RID: 37500
			private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400927D RID: 37501
			private static readonly System.IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400927E RID: 37502
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400927F RID: 37503
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyEffectsToNPC_b__26_0_Internal_Int32_Property_0;

			// Token: 0x04009280 RID: 37504
			private static readonly System.IntPtr NativeMethodInfoPtr__ClearEffectsFromNPC_b__27_0_Internal_Int32_Property_0;

			// Token: 0x04009281 RID: 37505
			private static readonly System.IntPtr NativeMethodInfoPtr__ApplyEffectsToPlayer_b__28_0_Internal_Int32_Property_0;

			// Token: 0x04009282 RID: 37506
			private static readonly System.IntPtr NativeMethodInfoPtr__ClearEffectsFromPlayer_b__29_0_Internal_Int32_Property_0;
		}
	}
}
