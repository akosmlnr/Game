using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building.Doors
{
	// Token: 0x020004E7 RID: 1255
	public class DoorKnocker : MonoBehaviour
	{
		// Token: 0x06006CD7 RID: 27863 RVA: 0x001E7798 File Offset: 0x001E5998
		// Note: this type is marked as 'beforefieldinit'.
		static DoorKnocker()
		{
			Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building.Doors", "DoorKnocker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr);
			DoorKnocker.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "Anim");
			DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSoundClipName");
			DoorKnocker.NativeFieldInfoPtr_KnockingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, "KnockingSound");
			DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100677186);
			DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100677187);
			DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr, 100677188);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x001E7840 File Offset: 0x001E5A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219637, XrefRangeEnd = 219641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Knock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_Knock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x001E7874 File Offset: 0x001E5A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219641, XrefRangeEnd = 219643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayKnockingSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x001E78A8 File Offset: 0x001E5AA8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorKnocker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorKnocker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorKnocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x000333A2 File Offset: 0x000315A2
		public DoorKnocker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06006CDC RID: 27868 RVA: 0x001E78E4 File Offset: 0x001E5AE4
		// (set) Token: 0x06006CDD RID: 27869 RVA: 0x000333AB File Offset: 0x000315AB
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06006CDE RID: 27870 RVA: 0x001E7914 File Offset: 0x001E5B14
		// (set) Token: 0x06006CDF RID: 27871 RVA: 0x000333CA File Offset: 0x000315CA
		public unsafe string KnockingSoundClipName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSoundClipName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06006CE0 RID: 27872 RVA: 0x001E793C File Offset: 0x001E5B3C
		// (set) Token: 0x06006CE1 RID: 27873 RVA: 0x000333E9 File Offset: 0x000315E9
		public unsafe AudioSource KnockingSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorKnocker.NativeFieldInfoPtr_KnockingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A7E RID: 19070
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04004A7F RID: 19071
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSoundClipName;

		// Token: 0x04004A80 RID: 19072
		private static readonly IntPtr NativeFieldInfoPtr_KnockingSound;

		// Token: 0x04004A81 RID: 19073
		private static readonly IntPtr NativeMethodInfoPtr_Knock_Public_Void_0;

		// Token: 0x04004A82 RID: 19074
		private static readonly IntPtr NativeMethodInfoPtr_PlayKnockingSound_Public_Void_0;

		// Token: 0x04004A83 RID: 19075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
