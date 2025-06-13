using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C3 RID: 963
	public class VisibilityController : MonoBehaviour
	{
		// Token: 0x06004A5E RID: 19038 RVA: 0x0016C7CC File Offset: 0x0016A9CC
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityController()
		{
			Il2CppClassPointerStore<VisibilityController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "VisibilityController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr);
			VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, "visibleOnlyInFullscreen");
			VisibilityController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672597);
			VisibilityController.NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672598);
			VisibilityController.NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672599);
			VisibilityController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672600);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0016C860 File Offset: 0x0016AA60
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x0016C894 File Offset: 0x0016AA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167368, XrefRangeEnd = 167370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnterFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x0016C8C8 File Offset: 0x0016AAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167370, XrefRangeEnd = 167372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExitFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x0016C8FC File Offset: 0x0016AAFC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 167373, RefRangeEnd = 167389, XrefRangeStart = 167372, XrefRangeEnd = 167373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x00023A98 File Offset: 0x00021C98
		public VisibilityController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06004A64 RID: 19044 RVA: 0x0016C938 File Offset: 0x0016AB38
		// (set) Token: 0x06004A65 RID: 19045 RVA: 0x00023AA1 File Offset: 0x00021CA1
		public unsafe bool visibleOnlyInFullscreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen)) = value;
			}
		}

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeFieldInfoPtr_visibleOnlyInFullscreen;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
