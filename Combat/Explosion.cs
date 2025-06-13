using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x020004B3 RID: 1203
	public class Explosion : MonoBehaviour
	{
		// Token: 0x0600672A RID: 26410 RVA: 0x001D38BC File Offset: 0x001D1ABC
		// Note: this type is marked as 'beforefieldinit'.
		static Explosion()
		{
			Il2CppClassPointerStore<Explosion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Explosion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Explosion>.NativeClassPtr);
			Explosion.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Explosion>.NativeClassPtr, "Sound");
			Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100676449);
			Explosion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Explosion>.NativeClassPtr, 100676450);
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x001D3928 File Offset: 0x001D1B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210245, RefRangeEnd = 210246, XrefRangeStart = 210144, XrefRangeEnd = 210245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Vector3 origin, ExplosionData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x001D3974 File Offset: 0x001D1B74
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Explosion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Explosion>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Explosion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x000308E1 File Offset: 0x0002EAE1
		public Explosion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x001D39B0 File Offset: 0x001D1BB0
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x000308EA File Offset: 0x0002EAEA
		public unsafe AudioSourceController Sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Explosion.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004663 RID: 18019
		private static readonly IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x04004664 RID: 18020
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Vector3_ExplosionData_0;

		// Token: 0x04004665 RID: 18021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
