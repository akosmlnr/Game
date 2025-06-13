using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200047A RID: 1146
	public static class LayerUtility : Il2CppSystem.Object
	{
		// Token: 0x06006294 RID: 25236 RVA: 0x0002E600 File Offset: 0x0002C800
		// Note: this type is marked as 'beforefieldinit'.
		static LayerUtility()
		{
			Il2CppClassPointerStore<LayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr);
			LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100675933);
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x001C4504 File Offset: 0x001C2704
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 203987, RefRangeEnd = 204011, XrefRangeStart = 203981, XrefRangeEnd = 203987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerNumber;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x0002E639 File Offset: 0x0002C839
		public LayerUtility(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400434D RID: 17229
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;
	}
}
