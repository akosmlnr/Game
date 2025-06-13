using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000205 RID: 517
	[System.Serializable]
	public class PollResponseWrapper : Il2CppSystem.Object
	{
		// Token: 0x0600296E RID: 10606 RVA: 0x000F6574 File Offset: 0x000F4774
		// Note: this type is marked as 'beforefieldinit'.
		static PollResponseWrapper()
		{
			Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollResponseWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr);
			PollResponseWrapper.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr, "success");
			PollResponseWrapper.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr, "data");
			PollResponseWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr, 100668011);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000F65E0 File Offset: 0x000F47E0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollResponseWrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponseWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00016673 File Offset: 0x00014873
		public PollResponseWrapper(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000F661C File Offset: 0x000F481C
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x0001667C File Offset: 0x0001487C
		public unsafe bool success
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_success);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_success)) = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x000F6644 File Offset: 0x000F4844
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x00016697 File Offset: 0x00014897
		public unsafe PollResponse data
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_data);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollResponse>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B79 RID: 7033
		private static readonly System.IntPtr NativeFieldInfoPtr_success;

		// Token: 0x04001B7A RID: 7034
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001B7B RID: 7035
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
