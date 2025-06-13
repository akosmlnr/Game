using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000606 RID: 1542
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x060085C5 RID: 34245 RVA: 0x0023ACA4 File Offset: 0x00238EA4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemGiver()
		{
			Il2CppClassPointerStore<ItemGiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemGiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr);
			ItemGiver.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Item");
			ItemGiver.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Quantity");
			ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100680117);
			ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100680118);
		}

		// Token: 0x060085C6 RID: 34246 RVA: 0x0023AD24 File Offset: 0x00238F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251080, XrefRangeEnd = 251086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Give()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085C7 RID: 34247 RVA: 0x0023AD58 File Offset: 0x00238F58
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemGiver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060085C8 RID: 34248 RVA: 0x0003F49F File Offset: 0x0003D69F
		public ItemGiver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700283E RID: 10302
		// (get) Token: 0x060085C9 RID: 34249 RVA: 0x0023AD94 File Offset: 0x00238F94
		// (set) Token: 0x060085CA RID: 34250 RVA: 0x0003F4A8 File Offset: 0x0003D6A8
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700283F RID: 10303
		// (get) Token: 0x060085CB RID: 34251 RVA: 0x0023ADC4 File Offset: 0x00238FC4
		// (set) Token: 0x060085CC RID: 34252 RVA: 0x0003F4C7 File Offset: 0x0003D6C7
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04005B11 RID: 23313
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04005B12 RID: 23314
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005B13 RID: 23315
		private static readonly IntPtr NativeMethodInfoPtr_Give_Public_Void_0;

		// Token: 0x04005B14 RID: 23316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
