using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200039D RID: 925
	public class GeneralStoreMerchant : Merchant
	{
		// Token: 0x0600475A RID: 18266 RVA: 0x000228CE File Offset: 0x00020ACE
		// Note: this type is marked as 'beforefieldinit'.
		static GeneralStoreMerchant()
		{
			Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "GeneralStoreMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr);
			GeneralStoreMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr, 100672148);
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x00160318 File Offset: 0x0015E518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162617, XrefRangeEnd = 162622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GeneralStoreMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralStoreMerchant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneralStoreMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x00022907 File Offset: 0x00020B07
		public GeneralStoreMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
