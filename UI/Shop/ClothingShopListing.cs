using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000732 RID: 1842
	public class ClothingShopListing : ShopListing
	{
		// Token: 0x0600A48C RID: 42124 RVA: 0x00297F90 File Offset: 0x00296190
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopListing()
		{
			Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr);
			ClothingShopListing.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, "Color");
			ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, 100683524);
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x00297FE8 File Offset: 0x002961E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288822, XrefRangeEnd = 288823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x00050B8B File Offset: 0x0004ED8B
		public ClothingShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A48F RID: 42127 RVA: 0x00298024 File Offset: 0x00296224
		// (set) Token: 0x0600A490 RID: 42128 RVA: 0x00050B94 File Offset: 0x0004ED94
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04006E53 RID: 28243
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04006E54 RID: 28244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
