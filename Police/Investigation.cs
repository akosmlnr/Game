using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x02000206 RID: 518
	public class Investigation : Il2CppSystem.Object
	{
		// Token: 0x06002975 RID: 10613 RVA: 0x000F6674 File Offset: 0x000F4874
		// Note: this type is marked as 'beforefieldinit'.
		static Investigation()
		{
			Il2CppClassPointerStore<Investigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "Investigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Investigation>.NativeClassPtr);
			Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Investigation>.NativeClassPtr, "<CurrentProgress>k__BackingField");
			Investigation.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Investigation>.NativeClassPtr, "<Target>k__BackingField");
			Investigation.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100668012);
			Investigation.NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100668013);
			Investigation.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100668014);
			Investigation.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100668015);
			Investigation.NativeMethodInfoPtr__ctor_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100668016);
			Investigation.NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Investigation>.NativeClassPtr, 100668017);
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x000F6744 File Offset: 0x000F4944
		// (set) Token: 0x06002977 RID: 10615 RVA: 0x000F6780 File Offset: 0x000F4980
		public unsafe float CurrentProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31384, RefRangeEnd = 31388, XrefRangeStart = 31384, XrefRangeEnd = 31388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x000F67C0 File Offset: 0x000F49C0
		// (set) Token: 0x06002979 RID: 10617 RVA: 0x000F6800 File Offset: 0x000F4A00
		public unsafe Player Target
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000F6844 File Offset: 0x000F4A44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 122438, RefRangeEnd = 122443, XrefRangeStart = 122436, XrefRangeEnd = 122438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Investigation(Player target) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Investigation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr__ctor_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000F6890 File Offset: 0x000F4A90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 122443, RefRangeEnd = 122449, XrefRangeStart = 122443, XrefRangeEnd = 122443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Investigation.NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000166B6 File Offset: 0x000148B6
		public Investigation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x000F68D0 File Offset: 0x000F4AD0
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x000166BF File Offset: 0x000148BF
		public unsafe float _CurrentProgress_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__CurrentProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x000F68F8 File Offset: 0x000F4AF8
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x000166DA File Offset: 0x000148DA
		public unsafe Player _Target_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__Target_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Investigation.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B7C RID: 7036
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentProgress_k__BackingField;

		// Token: 0x04001B7D RID: 7037
		private static readonly System.IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04001B7E RID: 7038
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentProgress_Public_get_Single_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentProgress_Protected_set_Void_Single_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeProgress_Public_Void_Single_0;
	}
}
