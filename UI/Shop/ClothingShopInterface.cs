using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000731 RID: 1841
	public class ClothingShopInterface : ShopInterface
	{
		// Token: 0x0600A480 RID: 42112 RVA: 0x00297CC0 File Offset: 0x00295EC0
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopInterface()
		{
			Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr);
			ClothingShopInterface.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, "ColorPicker");
			ClothingShopInterface.NativeFieldInfoPtr__selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, "_selectedListing");
			ClothingShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683518);
			ClothingShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683519);
			ClothingShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683520);
			ClothingShopInterface.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683521);
			ClothingShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683522);
			ClothingShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683523);
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x00297D90 File Offset: 0x00295F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288719, XrefRangeEnd = 288730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x00297DCC File Offset: 0x00295FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288730, XrefRangeEnd = 288734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ListingClicked(ListingUI listingUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listingUI);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x00297E1C File Offset: 0x0029601C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288734, XrefRangeEnd = 288744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x00297E6C File Offset: 0x0029606C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288744, XrefRangeEnd = 288750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopInterface.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A485 RID: 42117 RVA: 0x00297EAC File Offset: 0x002960AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288750, XrefRangeEnd = 288818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A486 RID: 42118 RVA: 0x00297EF4 File Offset: 0x002960F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288818, XrefRangeEnd = 288822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x00050B44 File Offset: 0x0004ED44
		public ClothingShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A488 RID: 42120 RVA: 0x00297F30 File Offset: 0x00296130
		// (set) Token: 0x0600A489 RID: 42121 RVA: 0x00050B4D File Offset: 0x0004ED4D
		public unsafe ShopColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x00297F60 File Offset: 0x00296160
		// (set) Token: 0x0600A48B RID: 42123 RVA: 0x00050B6C File Offset: 0x0004ED6C
		public unsafe ShopListing _selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr__selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr__selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006E4B RID: 28235
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x04006E4C RID: 28236
		private static readonly IntPtr NativeFieldInfoPtr__selectedListing;

		// Token: 0x04006E4D RID: 28237
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006E4E RID: 28238
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0;

		// Token: 0x04006E4F RID: 28239
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x04006E50 RID: 28240
		private static readonly IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04006E51 RID: 28241
		private static readonly IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0;

		// Token: 0x04006E52 RID: 28242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
