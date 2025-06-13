using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B8 RID: 1464
	public class LiquidMethVisuals : MonoBehaviour
	{
		// Token: 0x06007FD5 RID: 32725 RVA: 0x00225B4C File Offset: 0x00223D4C
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMethVisuals()
		{
			Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "LiquidMethVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr);
			LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "StaticLiquidMesh");
			LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "LiquidContainer");
			LiquidMethVisuals.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, "PourParticles");
			LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679379);
			LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr, 100679380);
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00225BE0 File Offset: 0x00223DE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 242023, RefRangeEnd = 242026, XrefRangeStart = 242004, XrefRangeEnd = 242023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(LiquidMethDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x00225C24 File Offset: 0x00223E24
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMethVisuals>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x0003C854 File Offset: 0x0003AA54
		public LiquidMethVisuals(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x06007FD9 RID: 32729 RVA: 0x00225C60 File Offset: 0x00223E60
		// (set) Token: 0x06007FDA RID: 32730 RVA: 0x0003C85D File Offset: 0x0003AA5D
		public unsafe MeshRenderer StaticLiquidMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_StaticLiquidMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002681 RID: 9857
		// (get) Token: 0x06007FDB RID: 32731 RVA: 0x00225C90 File Offset: 0x00223E90
		// (set) Token: 0x06007FDC RID: 32732 RVA: 0x0003C87C File Offset: 0x0003AA7C
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002682 RID: 9858
		// (get) Token: 0x06007FDD RID: 32733 RVA: 0x00225CC0 File Offset: 0x00223EC0
		// (set) Token: 0x06007FDE RID: 32734 RVA: 0x0003C89B File Offset: 0x0003AA9B
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMethVisuals.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056F6 RID: 22262
		private static readonly IntPtr NativeFieldInfoPtr_StaticLiquidMesh;

		// Token: 0x040056F7 RID: 22263
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x040056F8 RID: 22264
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x040056F9 RID: 22265
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_LiquidMethDefinition_0;

		// Token: 0x040056FA RID: 22266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
