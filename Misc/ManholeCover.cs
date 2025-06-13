using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000795 RID: 1941
	public class ManholeCover : MonoBehaviour
	{
		// Token: 0x0600B811 RID: 47121 RVA: 0x002E040C File Offset: 0x002DE60C
		// Note: this type is marked as 'beforefieldinit'.
		static ManholeCover()
		{
			Il2CppClassPointerStore<ManholeCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ManholeCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr);
			ManholeCover.NativeFieldInfoPtr_SteamParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamParticles");
			ManholeCover.NativeFieldInfoPtr_SteamColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamColor");
			ManholeCover.NativeFieldInfoPtr_SteamAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, "SteamAlpha");
			ManholeCover.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100686121);
			ManholeCover.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100686122);
			ManholeCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr, 100686123);
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x002E04B4 File Offset: 0x002DE6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315212, XrefRangeEnd = 315230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x002E04E8 File Offset: 0x002DE6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315230, XrefRangeEnd = 315240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x002E051C File Offset: 0x002DE71C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManholeCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManholeCover>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManholeCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x00059DDA File Offset: 0x00057FDA
		public ManholeCover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600B816 RID: 47126 RVA: 0x002E0558 File Offset: 0x002DE758
		// (set) Token: 0x0600B817 RID: 47127 RVA: 0x00059DE3 File Offset: 0x00057FE3
		public unsafe ParticleSystem SteamParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600B818 RID: 47128 RVA: 0x002E0588 File Offset: 0x002DE788
		// (set) Token: 0x0600B819 RID: 47129 RVA: 0x00059E02 File Offset: 0x00058002
		public unsafe Gradient SteamColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600B81A RID: 47130 RVA: 0x002E05B8 File Offset: 0x002DE7B8
		// (set) Token: 0x0600B81B RID: 47131 RVA: 0x00059E21 File Offset: 0x00058021
		public unsafe AnimationCurve SteamAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamAlpha);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManholeCover.NativeFieldInfoPtr_SteamAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C3F RID: 31807
		private static readonly IntPtr NativeFieldInfoPtr_SteamParticles;

		// Token: 0x04007C40 RID: 31808
		private static readonly IntPtr NativeFieldInfoPtr_SteamColor;

		// Token: 0x04007C41 RID: 31809
		private static readonly IntPtr NativeFieldInfoPtr_SteamAlpha;

		// Token: 0x04007C42 RID: 31810
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007C43 RID: 31811
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04007C44 RID: 31812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
