using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000204 RID: 516
	[System.Serializable]
	public class PollResponse : Il2CppSystem.Object
	{
		// Token: 0x06002961 RID: 10593 RVA: 0x000F62C8 File Offset: 0x000F44C8
		// Note: this type is marked as 'beforefieldinit'.
		static PollResponse()
		{
			Il2CppClassPointerStore<PollResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollResponse>.NativeClassPtr);
			PollResponse.NativeFieldInfoPtr_polls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, "polls");
			PollResponse.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, "active");
			PollResponse.NativeFieldInfoPtr_confirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, "confirmed");
			PollResponse.NativeMethodInfoPtr_GetActive_Public_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668006);
			PollResponse.NativeMethodInfoPtr_GetConfirmed_Public_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668007);
			PollResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668008);
			PollResponse.NativeMethodInfoPtr__GetActive_b__3_0_Private_Boolean_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668009);
			PollResponse.NativeMethodInfoPtr__GetConfirmed_b__4_0_Private_Boolean_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668010);
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000F6398 File Offset: 0x000F4598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122423, RefRangeEnd = 122425, XrefRangeStart = 122414, XrefRangeEnd = 122423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollData GetActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr_GetActive_Public_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x000F63D8 File Offset: 0x000F45D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122434, RefRangeEnd = 122436, XrefRangeStart = 122425, XrefRangeEnd = 122434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollData GetConfirmed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr_GetConfirmed_Public_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr2) : null;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000F6418 File Offset: 0x000F4618
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollResponse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollResponse>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x000F6454 File Offset: 0x000F4654
		[CallerCount(0)]
		public unsafe bool _GetActive_b__3_0(PollData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr__GetActive_b__3_0_Private_Boolean_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x000F64A4 File Offset: 0x000F46A4
		[CallerCount(0)]
		public unsafe bool _GetConfirmed_b__4_0(PollData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr__GetConfirmed_b__4_0_Private_Boolean_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00016615 File Offset: 0x00014815
		public PollResponse(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000F64F4 File Offset: 0x000F46F4
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0001661E File Offset: 0x0001481E
		public unsafe Il2CppReferenceArray<PollData> polls
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_polls);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PollData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_polls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600296A RID: 10602 RVA: 0x000F6524 File Offset: 0x000F4724
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x0001663D File Offset: 0x0001483D
		public unsafe int active
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x000F654C File Offset: 0x000F474C
		// (set) Token: 0x0600296D RID: 10605 RVA: 0x00016658 File Offset: 0x00014858
		public unsafe int confirmed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_confirmed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_confirmed)) = value;
			}
		}

		// Token: 0x04001B71 RID: 7025
		private static readonly System.IntPtr NativeFieldInfoPtr_polls;

		// Token: 0x04001B72 RID: 7026
		private static readonly System.IntPtr NativeFieldInfoPtr_active;

		// Token: 0x04001B73 RID: 7027
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmed;

		// Token: 0x04001B74 RID: 7028
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Public_PollData_0;

		// Token: 0x04001B75 RID: 7029
		private static readonly System.IntPtr NativeMethodInfoPtr_GetConfirmed_Public_PollData_0;

		// Token: 0x04001B76 RID: 7030
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B77 RID: 7031
		private static readonly System.IntPtr NativeMethodInfoPtr__GetActive_b__3_0_Private_Boolean_PollData_0;

		// Token: 0x04001B78 RID: 7032
		private static readonly System.IntPtr NativeMethodInfoPtr__GetConfirmed_b__4_0_Private_Boolean_PollData_0;
	}
}
