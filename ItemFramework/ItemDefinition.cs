using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.UI.Items;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000605 RID: 1541
	[Serializable]
	public class ItemDefinition : ScriptableObject
	{
		// Token: 0x060085A3 RID: 34211 RVA: 0x0023A818 File Offset: 0x00238A18
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinition()
		{
			Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr);
			ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "DEFAULT_STACK_LIMIT");
			ItemDefinition.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Name");
			ItemDefinition.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Description");
			ItemDefinition.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "ID");
			ItemDefinition.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Icon");
			ItemDefinition.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Category");
			ItemDefinition.NativeFieldInfoPtr_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Keywords");
			ItemDefinition.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "AvailableInDemo");
			ItemDefinition.NativeFieldInfoPtr_UsableInFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "UsableInFilters");
			ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "LabelDisplayColor");
			ItemDefinition.NativeFieldInfoPtr_StackLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "StackLimit");
			ItemDefinition.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Equippable");
			ItemDefinition.NativeFieldInfoPtr_CustomItemUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomItemUI");
			ItemDefinition.NativeFieldInfoPtr_CustomInfoContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomInfoContent");
			ItemDefinition.NativeFieldInfoPtr_legalStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "legalStatus");
			ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100680115);
			ItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100680116);
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x0023A99C File Offset: 0x00238B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251071, XrefRangeEnd = 251077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x0023A9F4 File Offset: 0x00238BF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 251078, RefRangeEnd = 251080, XrefRangeStart = 251077, XrefRangeEnd = 251078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085A6 RID: 34214 RVA: 0x0003F2EE File Offset: 0x0003D4EE
		public ItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700282F RID: 10287
		// (get) Token: 0x060085A7 RID: 34215 RVA: 0x0023AA30 File Offset: 0x00238C30
		// (set) Token: 0x060085A8 RID: 34216 RVA: 0x0003F2F7 File Offset: 0x0003D4F7
		public unsafe static int DEFAULT_STACK_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemDefinition.NativeFieldInfoPtr_DEFAULT_STACK_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17002830 RID: 10288
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x0023AA4C File Offset: 0x00238C4C
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x0003F305 File Offset: 0x0003D505
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x0023AA74 File Offset: 0x00238C74
		// (set) Token: 0x060085AC RID: 34220 RVA: 0x0003F324 File Offset: 0x0003D524
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x0023AA9C File Offset: 0x00238C9C
		// (set) Token: 0x060085AE RID: 34222 RVA: 0x0003F343 File Offset: 0x0003D543
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x060085AF RID: 34223 RVA: 0x0023AAC4 File Offset: 0x00238CC4
		// (set) Token: 0x060085B0 RID: 34224 RVA: 0x0003F362 File Offset: 0x0003D562
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x060085B1 RID: 34225 RVA: 0x0023AAF4 File Offset: 0x00238CF4
		// (set) Token: 0x060085B2 RID: 34226 RVA: 0x0003F381 File Offset: 0x0003D581
		public unsafe EItemCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x060085B3 RID: 34227 RVA: 0x0023AB1C File Offset: 0x00238D1C
		// (set) Token: 0x060085B4 RID: 34228 RVA: 0x0003F39C File Offset: 0x0003D59C
		public unsafe Il2CppStringArray Keywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Keywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Keywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x060085B5 RID: 34229 RVA: 0x0023AB4C File Offset: 0x00238D4C
		// (set) Token: 0x060085B6 RID: 34230 RVA: 0x0003F3BB File Offset: 0x0003D5BB
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x17002837 RID: 10295
		// (get) Token: 0x060085B7 RID: 34231 RVA: 0x0023AB74 File Offset: 0x00238D74
		// (set) Token: 0x060085B8 RID: 34232 RVA: 0x0003F3D6 File Offset: 0x0003D5D6
		public unsafe bool UsableInFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_UsableInFilters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_UsableInFilters)) = value;
			}
		}

		// Token: 0x17002838 RID: 10296
		// (get) Token: 0x060085B9 RID: 34233 RVA: 0x0023AB9C File Offset: 0x00238D9C
		// (set) Token: 0x060085BA RID: 34234 RVA: 0x0003F3F1 File Offset: 0x0003D5F1
		public unsafe Color LabelDisplayColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_LabelDisplayColor)) = value;
			}
		}

		// Token: 0x17002839 RID: 10297
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x0023ABC4 File Offset: 0x00238DC4
		// (set) Token: 0x060085BC RID: 34236 RVA: 0x0003F40C File Offset: 0x0003D60C
		public unsafe int StackLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_StackLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_StackLimit)) = value;
			}
		}

		// Token: 0x1700283A RID: 10298
		// (get) Token: 0x060085BD RID: 34237 RVA: 0x0023ABEC File Offset: 0x00238DEC
		// (set) Token: 0x060085BE RID: 34238 RVA: 0x0003F427 File Offset: 0x0003D627
		public unsafe Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283B RID: 10299
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x0023AC1C File Offset: 0x00238E1C
		// (set) Token: 0x060085C0 RID: 34240 RVA: 0x0003F446 File Offset: 0x0003D646
		public unsafe ItemUI CustomItemUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283C RID: 10300
		// (get) Token: 0x060085C1 RID: 34241 RVA: 0x0023AC4C File Offset: 0x00238E4C
		// (set) Token: 0x060085C2 RID: 34242 RVA: 0x0003F465 File Offset: 0x0003D665
		public unsafe ItemInfoContent CustomInfoContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283D RID: 10301
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x0023AC7C File Offset: 0x00238E7C
		// (set) Token: 0x060085C4 RID: 34244 RVA: 0x0003F484 File Offset: 0x0003D684
		public unsafe ELegalStatus legalStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_legalStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_legalStatus)) = value;
			}
		}

		// Token: 0x04005B00 RID: 23296
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_STACK_LIMIT;

		// Token: 0x04005B01 RID: 23297
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04005B02 RID: 23298
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04005B03 RID: 23299
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005B04 RID: 23300
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04005B05 RID: 23301
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04005B06 RID: 23302
		private static readonly IntPtr NativeFieldInfoPtr_Keywords;

		// Token: 0x04005B07 RID: 23303
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04005B08 RID: 23304
		private static readonly IntPtr NativeFieldInfoPtr_UsableInFilters;

		// Token: 0x04005B09 RID: 23305
		private static readonly IntPtr NativeFieldInfoPtr_LabelDisplayColor;

		// Token: 0x04005B0A RID: 23306
		private static readonly IntPtr NativeFieldInfoPtr_StackLimit;

		// Token: 0x04005B0B RID: 23307
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04005B0C RID: 23308
		private static readonly IntPtr NativeFieldInfoPtr_CustomItemUI;

		// Token: 0x04005B0D RID: 23309
		private static readonly IntPtr NativeFieldInfoPtr_CustomInfoContent;

		// Token: 0x04005B0E RID: 23310
		private static readonly IntPtr NativeFieldInfoPtr_legalStatus;

		// Token: 0x04005B0F RID: 23311
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x04005B10 RID: 23312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
