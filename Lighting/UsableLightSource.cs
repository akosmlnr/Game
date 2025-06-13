using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DA RID: 986
	public class UsableLightSource : MonoBehaviour
	{
		// Token: 0x06004BC3 RID: 19395 RVA: 0x00170E6C File Offset: 0x0016F06C
		// Note: this type is marked as 'beforefieldinit'.
		static UsableLightSource()
		{
			Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "UsableLightSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr);
			UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "GrowSpeedMultiplier");
			UsableLightSource.NativeFieldInfoPtr_isEmitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, "isEmitting");
			UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr, 100672768);
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x00170ED8 File Offset: 0x0016F0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168469, XrefRangeEnd = 168470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UsableLightSource() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsableLightSource>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UsableLightSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000245C3 File Offset: 0x000227C3
		public UsableLightSource(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x00170F14 File Offset: 0x0016F114
		// (set) Token: 0x06004BC7 RID: 19399 RVA: 0x000245CC File Offset: 0x000227CC
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x00170F3C File Offset: 0x0016F13C
		// (set) Token: 0x06004BC9 RID: 19401 RVA: 0x000245E7 File Offset: 0x000227E7
		public unsafe bool isEmitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UsableLightSource.NativeFieldInfoPtr_isEmitting)) = value;
			}
		}

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeFieldInfoPtr_isEmitting;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
