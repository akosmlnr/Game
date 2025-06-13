using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200038D RID: 909
	public static class NoiseUtility : Il2CppSystem.Object
	{
		// Token: 0x060045F0 RID: 17904 RVA: 0x00021F69 File Offset: 0x00020169
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseUtility()
		{
			Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr);
			NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr, 100671917);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x0015AC34 File Offset: 0x00158E34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 159844, RefRangeEnd = 159847, XrefRangeStart = 159812, XrefRangeEnd = 159844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EmitNoise(Vector3 origin, ENoiseType type, float range, GameObject source = null)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref range;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00021FA2 File Offset: 0x000201A2
		public NoiseUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002ED1 RID: 11985
		private static readonly System.IntPtr NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0;
	}
}
