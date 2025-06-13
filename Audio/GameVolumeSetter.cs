using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F4 RID: 1268
	public class GameVolumeSetter : MonoBehaviour
	{
		// Token: 0x06006E13 RID: 28179 RVA: 0x001EB060 File Offset: 0x001E9260
		// Note: this type is marked as 'beforefieldinit'.
		static GameVolumeSetter()
		{
			Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "GameVolumeSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr);
			GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, "VolumeMultiplier");
			GameVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, 100677307);
			GameVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr, 100677308);
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x001EB0CC File Offset: 0x001E92CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220896, XrefRangeEnd = 220902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x001EB100 File Offset: 0x001E9300
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77482, RefRangeEnd = 77486, XrefRangeStart = 77482, XrefRangeEnd = 77486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameVolumeSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameVolumeSetter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x00033DFB File Offset: 0x00031FFB
		public GameVolumeSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06006E17 RID: 28183 RVA: 0x001EB13C File Offset: 0x001E933C
		// (set) Token: 0x06006E18 RID: 28184 RVA: 0x00033E04 File Offset: 0x00032004
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameVolumeSetter.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x04004B4A RID: 19274
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004B4B RID: 19275
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004B4C RID: 19276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
