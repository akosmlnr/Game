using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200057E RID: 1406
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x06007AB2 RID: 31410 RVA: 0x00214468 File Offset: 0x00212668
		// Note: this type is marked as 'beforefieldinit'.
		static PlantHarvestable()
		{
			Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantHarvestable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr);
			PlantHarvestable.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "Product");
			PlantHarvestable.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "ProductQuantity");
			PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678783);
			PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678784);
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x002144E8 File Offset: 0x002126E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236302, XrefRangeEnd = 236385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Harvest(bool giveProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref giveProduct;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00214534 File Offset: 0x00212734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236385, XrefRangeEnd = 236386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x00039FB5 File Offset: 0x000381B5
		public PlantHarvestable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x00214570 File Offset: 0x00212770
		// (set) Token: 0x06007AB7 RID: 31415 RVA: 0x00039FBE File Offset: 0x000381BE
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x002145A0 File Offset: 0x002127A0
		// (set) Token: 0x06007AB9 RID: 31417 RVA: 0x00039FDD File Offset: 0x000381DD
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x0400539A RID: 21402
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x0400539B RID: 21403
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x0400539C RID: 21404
		private static readonly IntPtr NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400539D RID: 21405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
