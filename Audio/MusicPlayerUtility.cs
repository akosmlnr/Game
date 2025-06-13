using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F8 RID: 1272
	public class MusicPlayerUtility : MonoBehaviour
	{
		// Token: 0x06006E4D RID: 28237 RVA: 0x001EBAFC File Offset: 0x001E9CFC
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayerUtility()
		{
			Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr);
			MusicPlayerUtility.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100677332);
			MusicPlayerUtility.NativeMethodInfoPtr_StopTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100677333);
			MusicPlayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr, 100677334);
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x001EBB68 File Offset: 0x001E9D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221167, XrefRangeEnd = 221191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr_PlayTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x001EBBAC File Offset: 0x001E9DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221191, XrefRangeEnd = 221197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr_StopTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x001EBBE0 File Offset: 0x001E9DE0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayerUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayerUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayerUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x00033FB1 File Offset: 0x000321B1
		public MusicPlayerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004B6D RID: 19309
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_String_0;

		// Token: 0x04004B6E RID: 19310
		private static readonly IntPtr NativeMethodInfoPtr_StopTracks_Public_Void_0;

		// Token: 0x04004B6F RID: 19311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
