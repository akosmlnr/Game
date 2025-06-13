using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007A0 RID: 1952
	public class DarkMarketAccessZone : TimedAccessZone
	{
		// Token: 0x0600B905 RID: 47365 RVA: 0x002E31B0 File Offset: 0x002E13B0
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarketAccessZone()
		{
			Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarketAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr);
			DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100686206);
			DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr, 100686207);
		}

		// Token: 0x0600B906 RID: 47366 RVA: 0x002E3208 File Offset: 0x002E1408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316030, XrefRangeEnd = 316042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetIsOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarketAccessZone.NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B907 RID: 47367 RVA: 0x002E3250 File Offset: 0x002E1450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316042, XrefRangeEnd = 316043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarketAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarketAccessZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarketAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B908 RID: 47368 RVA: 0x0005A640 File Offset: 0x00058840
		public DarkMarketAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007CD6 RID: 31958
		private static readonly IntPtr NativeMethodInfoPtr_GetIsOpen_Protected_Virtual_Boolean_0;

		// Token: 0x04007CD7 RID: 31959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
