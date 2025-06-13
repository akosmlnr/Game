using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000607 RID: 1543
	[System.Serializable]
	public class ItemInstance : Il2CppSystem.Object
	{
		// Token: 0x060085CD RID: 34253 RVA: 0x0023ADEC File Offset: 0x00238FEC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemInstance()
		{
			Il2CppClassPointerStore<ItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr);
			ItemInstance.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "definition");
			ItemInstance.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "ID");
			ItemInstance.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "Quantity");
			ItemInstance.NativeFieldInfoPtr_onDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "onDataChanged");
			ItemInstance.NativeFieldInfoPtr_requestClearSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, "requestClearSlot");
			ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680119);
			ItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680120);
			ItemInstance.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680121);
			ItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680122);
			ItemInstance.NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680123);
			ItemInstance.NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680124);
			ItemInstance.NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680125);
			ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680126);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680127);
			ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680128);
			ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680129);
			ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680130);
			ItemInstance.NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680131);
			ItemInstance.NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680132);
			ItemInstance.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680133);
			ItemInstance.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680134);
			ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680135);
			ItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680136);
			ItemInstance.NativeMethodInfoPtr_RequestClearSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr, 100680137);
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x060085CE RID: 34254 RVA: 0x0023AFFC File Offset: 0x002391FC
		public unsafe ItemDefinition Definition
		{
			[CallerCount(138)]
			[CachedScanResults(RefRangeStart = 251102, RefRangeEnd = 251240, XrefRangeStart = 251086, XrefRangeEnd = 251102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x060085CF RID: 34255 RVA: 0x0023B03C File Offset: 0x0023923C
		public unsafe virtual string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251241, RefRangeEnd = 251243, XrefRangeStart = 251240, XrefRangeEnd = 251241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x060085D0 RID: 34256 RVA: 0x0023B080 File Offset: 0x00239280
		public unsafe virtual string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251243, XrefRangeEnd = 251244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x060085D1 RID: 34257 RVA: 0x0023B0C4 File Offset: 0x002392C4
		public unsafe virtual Sprite Icon
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251245, RefRangeEnd = 251247, XrefRangeStart = 251244, XrefRangeEnd = 251245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x060085D2 RID: 34258 RVA: 0x0023B110 File Offset: 0x00239310
		public unsafe virtual EItemCategory Category
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251247, XrefRangeEnd = 251248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700284A RID: 10314
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x0023B158 File Offset: 0x00239358
		public unsafe virtual int StackLimit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251248, XrefRangeEnd = 251249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x060085D4 RID: 34260 RVA: 0x0023B1A0 File Offset: 0x002393A0
		public unsafe virtual Color LabelDisplayColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251249, XrefRangeEnd = 251250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x060085D5 RID: 34261 RVA: 0x0023B1E8 File Offset: 0x002393E8
		public unsafe virtual Equippable Equippable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 251251, RefRangeEnd = 251253, XrefRangeStart = 251250, XrefRangeEnd = 251251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
		}

		// Token: 0x060085D6 RID: 34262 RVA: 0x0023B234 File Offset: 0x00239434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251257, RefRangeEnd = 251258, XrefRangeStart = 251253, XrefRangeEnd = 251257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085D7 RID: 34263 RVA: 0x0023B270 File Offset: 0x00239470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251265, RefRangeEnd = 251267, XrefRangeStart = 251258, XrefRangeEnd = 251265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemInstance>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085D8 RID: 34264 RVA: 0x0023B2CC File Offset: 0x002394CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 251268, RefRangeEnd = 251269, XrefRangeStart = 251267, XrefRangeEnd = 251268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref checkQuantities;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060085D9 RID: 34265 RVA: 0x0023B334 File Offset: 0x00239534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251269, XrefRangeEnd = 251275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref overrideQuantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060085DA RID: 34266 RVA: 0x0023B38C File Offset: 0x0023958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251275, XrefRangeEnd = 251283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060085DB RID: 34267 RVA: 0x0023B3D4 File Offset: 0x002395D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 251283, RefRangeEnd = 251286, XrefRangeStart = 251283, XrefRangeEnd = 251283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDataChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085DC RID: 34268 RVA: 0x0023B408 File Offset: 0x00239608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251286, XrefRangeEnd = 251297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085DD RID: 34269 RVA: 0x0023B448 File Offset: 0x00239648
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 251308, RefRangeEnd = 251318, XrefRangeStart = 251297, XrefRangeEnd = 251308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085DE RID: 34270 RVA: 0x0023B488 File Offset: 0x00239688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251318, XrefRangeEnd = 251322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x060085DF RID: 34271 RVA: 0x0023B4D4 File Offset: 0x002396D4
		[CallerCount(0)]
		public unsafe virtual float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060085E0 RID: 34272 RVA: 0x0023B51C File Offset: 0x0023971C
		[CallerCount(0)]
		public unsafe void RequestClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemInstance.NativeMethodInfoPtr_RequestClearSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085E1 RID: 34273 RVA: 0x0003F4E2 File Offset: 0x0003D6E2
		public ItemInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002840 RID: 10304
		// (get) Token: 0x060085E2 RID: 34274 RVA: 0x0023B550 File Offset: 0x00239750
		// (set) Token: 0x060085E3 RID: 34275 RVA: 0x0003F4EB File Offset: 0x0003D6EB
		public unsafe ItemDefinition definition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_definition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x0023B580 File Offset: 0x00239780
		// (set) Token: 0x060085E5 RID: 34277 RVA: 0x0003F50A File Offset: 0x0003D70A
		public unsafe string ID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x060085E6 RID: 34278 RVA: 0x0023B5A8 File Offset: 0x002397A8
		// (set) Token: 0x060085E7 RID: 34279 RVA: 0x0003F529 File Offset: 0x0003D729
		public unsafe int Quantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x060085E8 RID: 34280 RVA: 0x0023B5D0 File Offset: 0x002397D0
		// (set) Token: 0x060085E9 RID: 34281 RVA: 0x0003F544 File Offset: 0x0003D744
		public unsafe Il2CppSystem.Action onDataChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_onDataChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_onDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x060085EA RID: 34282 RVA: 0x0023B600 File Offset: 0x00239800
		// (set) Token: 0x060085EB RID: 34283 RVA: 0x0003F563 File Offset: 0x0003D763
		public unsafe Il2CppSystem.Action requestClearSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_requestClearSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemInstance.NativeFieldInfoPtr_requestClearSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005B15 RID: 23317
		private static readonly System.IntPtr NativeFieldInfoPtr_definition;

		// Token: 0x04005B16 RID: 23318
		private static readonly System.IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005B17 RID: 23319
		private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005B18 RID: 23320
		private static readonly System.IntPtr NativeFieldInfoPtr_onDataChanged;

		// Token: 0x04005B19 RID: 23321
		private static readonly System.IntPtr NativeFieldInfoPtr_requestClearSlot;

		// Token: 0x04005B1A RID: 23322
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ItemDefinition_0;

		// Token: 0x04005B1B RID: 23323
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x04005B1C RID: 23324
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_New_get_String_0;

		// Token: 0x04005B1D RID: 23325
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_New_get_Sprite_0;

		// Token: 0x04005B1E RID: 23326
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_Virtual_New_get_EItemCategory_0;

		// Token: 0x04005B1F RID: 23327
		private static readonly System.IntPtr NativeMethodInfoPtr_get_StackLimit_Public_Virtual_New_get_Int32_0;

		// Token: 0x04005B20 RID: 23328
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LabelDisplayColor_Public_Virtual_New_get_Color_0;

		// Token: 0x04005B21 RID: 23329
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_New_get_Equippable_0;

		// Token: 0x04005B22 RID: 23330
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005B23 RID: 23331
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04005B24 RID: 23332
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_New_Boolean_ItemInstance_Boolean_0;

		// Token: 0x04005B25 RID: 23333
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x04005B26 RID: 23334
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValidInstance_Public_Virtual_New_Boolean_0;

		// Token: 0x04005B27 RID: 23335
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDataChange_Protected_Void_0;

		// Token: 0x04005B28 RID: 23336
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x04005B29 RID: 23337
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_0;

		// Token: 0x04005B2A RID: 23338
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_New_ItemData_0;

		// Token: 0x04005B2B RID: 23339
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_New_Single_0;

		// Token: 0x04005B2C RID: 23340
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestClearSlot_Public_Void_0;
	}
}
