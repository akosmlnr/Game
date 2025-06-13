using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200022A RID: 554
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x06002D7C RID: 11644 RVA: 0x00103E6C File Offset: 0x0010206C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadEventTransmitter()
		{
			Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadEventTransmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr);
			LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, "onLoadComplete");
			LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668475);
			LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668476);
			LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668477);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00103EEC File Offset: 0x001020EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128220, XrefRangeEnd = 128232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00103F20 File Offset: 0x00102120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128232, XrefRangeEnd = 128233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00103F54 File Offset: 0x00102154
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadEventTransmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000185E1 File Offset: 0x000167E1
		public LoadEventTransmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x00103F90 File Offset: 0x00102190
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x000185EA File Offset: 0x000167EA
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
