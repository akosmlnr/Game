using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200039F RID: 927
	public class UndergroundMerchant : Merchant
	{
		// Token: 0x0600476B RID: 18283 RVA: 0x0002298D File Offset: 0x00020B8D
		// Note: this type is marked as 'beforefieldinit'.
		static UndergroundMerchant()
		{
			Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "UndergroundMerchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr);
			UndergroundMerchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr, 100672153);
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x001605B4 File Offset: 0x0015E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UndergroundMerchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UndergroundMerchant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UndergroundMerchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x000229C6 File Offset: 0x00020BC6
		public UndergroundMerchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
