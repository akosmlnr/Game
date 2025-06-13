using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000571 RID: 1393
	public class SetRendererMaterial : MonoBehaviour
	{
		// Token: 0x060079DF RID: 31199 RVA: 0x00212088 File Offset: 0x00210288
		// Note: this type is marked as 'beforefieldinit'.
		static SetRendererMaterial()
		{
			Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetRendererMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr);
			SetRendererMaterial.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, "Material");
			SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678724);
			SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr, 100678725);
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x002120F4 File Offset: 0x002102F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235786, XrefRangeEnd = 235795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr_SetMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00212128 File Offset: 0x00210328
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetRendererMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetRendererMaterial>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetRendererMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x000397A3 File Offset: 0x000379A3
		public SetRendererMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x00212164 File Offset: 0x00210364
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x000397AC File Offset: 0x000379AC
		public unsafe Material Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetRendererMaterial.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005324 RID: 21284
		private static readonly IntPtr NativeFieldInfoPtr_Material;

		// Token: 0x04005325 RID: 21285
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterial_Public_Void_0;

		// Token: 0x04005326 RID: 21286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
