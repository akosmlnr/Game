using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005A9 RID: 1449
	public class CookableModule : ItemModule
	{
		// Token: 0x06007EAE RID: 32430 RVA: 0x00222624 File Offset: 0x00220824
		// Note: this type is marked as 'beforefieldinit'.
		static CookableModule()
		{
			Il2CppClassPointerStore<CookableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "CookableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookableModule>.NativeClassPtr);
			CookableModule.NativeFieldInfoPtr_CookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookTime");
			CookableModule.NativeFieldInfoPtr_CookType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "CookType");
			CookableModule.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "Product");
			CookableModule.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductQuantity");
			CookableModule.NativeFieldInfoPtr_ProductShardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "ProductShardPrefab");
			CookableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "LiquidColor");
			CookableModule.NativeFieldInfoPtr_SolidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, "SolidColor");
			CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookableModule>.NativeClassPtr, 100679264);
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x002226F4 File Offset: 0x002208F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241207, XrefRangeEnd = 241208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookableModule>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x0003BDD3 File Offset: 0x00039FD3
		public CookableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06007EB1 RID: 32433 RVA: 0x00222730 File Offset: 0x00220930
		// (set) Token: 0x06007EB2 RID: 32434 RVA: 0x0003BDDC File Offset: 0x00039FDC
		public unsafe int CookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookTime)) = value;
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06007EB3 RID: 32435 RVA: 0x00222758 File Offset: 0x00220958
		// (set) Token: 0x06007EB4 RID: 32436 RVA: 0x0003BDF7 File Offset: 0x00039FF7
		public unsafe CookableModule.ECookableType CookType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_CookType)) = value;
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06007EB5 RID: 32437 RVA: 0x00222780 File Offset: 0x00220980
		// (set) Token: 0x06007EB6 RID: 32438 RVA: 0x0003BE12 File Offset: 0x0003A012
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06007EB7 RID: 32439 RVA: 0x002227B0 File Offset: 0x002209B0
		// (set) Token: 0x06007EB8 RID: 32440 RVA: 0x0003BE31 File Offset: 0x0003A031
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x002227D8 File Offset: 0x002209D8
		// (set) Token: 0x06007EBA RID: 32442 RVA: 0x0003BE4C File Offset: 0x0003A04C
		public unsafe Rigidbody ProductShardPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_ProductShardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x00222808 File Offset: 0x00220A08
		// (set) Token: 0x06007EBC RID: 32444 RVA: 0x0003BE6B File Offset: 0x0003A06B
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06007EBD RID: 32445 RVA: 0x00222830 File Offset: 0x00220A30
		// (set) Token: 0x06007EBE RID: 32446 RVA: 0x0003BE86 File Offset: 0x0003A086
		public unsafe Color SolidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookableModule.NativeFieldInfoPtr_SolidColor)) = value;
			}
		}

		// Token: 0x04005646 RID: 22086
		private static readonly IntPtr NativeFieldInfoPtr_CookTime;

		// Token: 0x04005647 RID: 22087
		private static readonly IntPtr NativeFieldInfoPtr_CookType;

		// Token: 0x04005648 RID: 22088
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x04005649 RID: 22089
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x0400564A RID: 22090
		private static readonly IntPtr NativeFieldInfoPtr_ProductShardPrefab;

		// Token: 0x0400564B RID: 22091
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x0400564C RID: 22092
		private static readonly IntPtr NativeFieldInfoPtr_SolidColor;

		// Token: 0x0400564D RID: 22093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B02 RID: 2818
		[OriginalName("Assembly-CSharp.dll", "", "ECookableType")]
		public enum ECookableType
		{
			// Token: 0x04009220 RID: 37408
			Liquid,
			// Token: 0x04009221 RID: 37409
			Solid
		}
	}
}
