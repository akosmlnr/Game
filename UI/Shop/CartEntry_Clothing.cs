using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200072F RID: 1839
	public class CartEntry_Clothing : CartEntry
	{
		// Token: 0x0600A469 RID: 42089 RVA: 0x0029781C File Offset: 0x00295A1C
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry_Clothing()
		{
			Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry_Clothing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr);
			CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100683507);
			CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr, 100683508);
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x00297874 File Offset: 0x00295A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288668, XrefRangeEnd = 288682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry_Clothing.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x002978B0 File Offset: 0x00295AB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry_Clothing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry_Clothing>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry_Clothing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x00050ABE File Offset: 0x0004ECBE
		public CartEntry_Clothing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006E3C RID: 28220
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_Void_0;

		// Token: 0x04006E3D RID: 28221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
