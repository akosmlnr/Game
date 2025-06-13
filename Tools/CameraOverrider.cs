using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000550 RID: 1360
	public class CameraOverrider : MonoBehaviour
	{
		// Token: 0x06007860 RID: 30816 RVA: 0x0020D95C File Offset: 0x0020BB5C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOverrider()
		{
			Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CameraOverrider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr);
			CameraOverrider.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, "FOV");
			CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100678550);
			CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr, 100678551);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x0020D9C8 File Offset: 0x0020BBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234482, XrefRangeEnd = 234496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x0020D9FC File Offset: 0x0020BBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234496, XrefRangeEnd = 234497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOverrider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOverrider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOverrider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00038CDB File Offset: 0x00036EDB
		public CameraOverrider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x0020DA38 File Offset: 0x0020BC38
		// (set) Token: 0x06007865 RID: 30821 RVA: 0x00038CE4 File Offset: 0x00036EE4
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOverrider.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x0400523F RID: 21055
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04005240 RID: 21056
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04005241 RID: 21057
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
