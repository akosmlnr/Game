using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000762 RID: 1890
	public class MethVisuals : MonoBehaviour
	{
		// Token: 0x0600ACB1 RID: 44209 RVA: 0x002B3724 File Offset: 0x002B1924
		// Note: this type is marked as 'beforefieldinit'.
		static MethVisuals()
		{
			Il2CppClassPointerStore<MethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr);
			MethVisuals.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, "Meshes");
			MethVisuals.NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, 100684565);
			MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr, 100684566);
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x002B3790 File Offset: 0x002B1990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(MethDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisuals.NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x002B37D4 File Offset: 0x002B19D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x00054D0F File Offset: 0x00052F0F
		public MethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600ACB5 RID: 44213 RVA: 0x002B3810 File Offset: 0x002B1A10
		// (set) Token: 0x0600ACB6 RID: 44214 RVA: 0x00054D18 File Offset: 0x00052F18
		public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisuals.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisuals.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040073F4 RID: 29684
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x040073F5 RID: 29685
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_MethDefinition_0;

		// Token: 0x040073F6 RID: 29686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
