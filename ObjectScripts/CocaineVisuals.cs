using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000761 RID: 1889
	public class CocaineVisuals : MonoBehaviour
	{
		// Token: 0x0600ACAB RID: 44203 RVA: 0x002B3608 File Offset: 0x002B1808
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineVisuals()
		{
			Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "CocaineVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr);
			CocaineVisuals.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, "Meshes");
			CocaineVisuals.NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, 100684563);
			CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr, 100684564);
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x002B3674 File Offset: 0x002B1874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299530, XrefRangeEnd = 299532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(CocaineDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisuals.NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x002B36B8 File Offset: 0x002B18B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x00054CE7 File Offset: 0x00052EE7
		public CocaineVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600ACAF RID: 44207 RVA: 0x002B36F4 File Offset: 0x002B18F4
		// (set) Token: 0x0600ACB0 RID: 44208 RVA: 0x00054CF0 File Offset: 0x00052EF0
		public unsafe Il2CppReferenceArray<MeshRenderer> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisuals.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisuals.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040073F1 RID: 29681
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x040073F2 RID: 29682
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_CocaineDefinition_0;

		// Token: 0x040073F3 RID: 29683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
